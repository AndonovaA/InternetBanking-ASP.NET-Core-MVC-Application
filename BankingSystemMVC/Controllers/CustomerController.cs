using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BankingSystemMVC.Data;
using BankingSystemMVC.Models;
using BankingSystemMVC.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace BankingSystemMVC.Controllers
{
    [Authorize(Roles = "Customer")]
    public class CustomerController : Controller
    {
        private readonly BankDbContext _context;
        private UserManager<AppUser> userManager;

        public CustomerController(BankDbContext context, UserManager<AppUser> manager)
        {
            _context = context;
            userManager = manager;
        }

        // GET: Customer/CustomerDetails/{customerId}
        public async Task<IActionResult> CustomerDetails(int id)  
        {
            AppUser loggedUser = await userManager.GetUserAsync(User);
            if (loggedUser.CustomerId != id)
            {
                return RedirectToAction("AccessDenied", "Account", null);
            }

            var customer = await _context.Customers.Include(c=>c.Accounts).Where(c=>c.Id == id).FirstOrDefaultAsync();

            if (customer != null)
                ViewData["CustomerName"] = customer.FullName; 
            else
                return NotFound();

            return View(customer);
        }

        // GET: Customer/CustomerAccount/{bankAccountId}
        public async Task<IActionResult> CustomerAccount(int id) 
        {
            AppUser loggedUser = await userManager.GetUserAsync(User);
            var Userid = loggedUser.CustomerId;
            IList<int> userAccounts = await _context.BankAccounts.Where(a => a.CustomerId == Userid).Select(a => a.Id).ToListAsync();

            if (! userAccounts.Contains(id))
            {
                return RedirectToAction("AccessDenied", "Account", null);
            }

            var account = await _context.BankAccounts.Include(b => b.Customer).Include(b => b.Product).Where(c => c.Id == id).FirstOrDefaultAsync();
            if (account == null)
                return NotFound();

            return View(account);
        }

        // GET: Customer/AccountReport/{bankAccountId}
        public async Task<IActionResult> AccountReport(int id, DateTime startDate, DateTime endDate) 
        {
            AppUser loggedUser = await userManager.GetUserAsync(User);
            var Userid = loggedUser.CustomerId;
            IList<int> userAccounts = await _context.BankAccounts.Where(a => a.CustomerId == Userid).Select(a => a.Id).ToListAsync();

            if (!userAccounts.Contains(id))
            {
                return RedirectToAction("AccessDenied", "Account", null);
            }

            IQueryable<Transaction> transactions = _context.Transactions.Include(t=>t.Account).Where(t => t.AccountId == id).OrderBy(t=>t.TransDate).AsQueryable();

            if (! transactions.ToList().Any())
                return RedirectToAction("CustomerAccount", new { id = id});

            DateTime temp = new DateTime(01, 1, 0001); //null
            if (startDate != temp  &&  endDate != temp)
            {
                transactions = transactions.Where(t => t.TransDate >= startDate && t.TransDate <= endDate);
            }

            AccountReportViewModel vm = new AccountReportViewModel
            {
                Transactions = await transactions.ToListAsync(),
                BankAccount = await _context.BankAccounts.FindAsync(id)
            };

            return View(vm);
        }

    }
}