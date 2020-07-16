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

namespace BankingSystemMVC.Controllers
{
    [Authorize(Roles = "Admin")]
    public class BankAccountsController : Controller
    {
        private readonly BankDbContext _context;

        public BankAccountsController(BankDbContext context)
        {
            _context = context;
        }

        // GET: BankAccounts
        public async Task<IActionResult> Index(string bankAccountProduct, string bankAccountEmployeeString)
        {
            IQueryable<BankAccount> accounts = _context.BankAccounts.AsQueryable();
            IQueryable<string> productQuery = _context.Products.Select(a => a.Id).Distinct();

            //eager loading
            accounts = accounts.Include(b => b.Customer).Include(b => b.Employee).Include(b => b.Product);

            if (bankAccountEmployeeString != null)
            {
                accounts = accounts.Where(a => (a.Employee.FirstName + " " + a.Employee.LastName).ToLower().Contains(bankAccountEmployeeString.ToLower()));
            }

            if (bankAccountProduct != null)
            {
                accounts = accounts.Where(a => a.ProductId.Equals(bankAccountProduct));
            }

            BankAccountFilterViewModel vm = new BankAccountFilterViewModel
            {
               Products = new SelectList(await productQuery.ToListAsync()),
               BankAccounts = await accounts.ToListAsync()

            };

            return View(vm);
        }

        // GET: BankAccounts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bankAccount = await _context.BankAccounts
                .Include(b => b.Customer)
                .Include(b => b.Employee)
                .Include(b => b.Product)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bankAccount == null)
            {
                return NotFound();
            }

            return View(bankAccount);
        }

        // GET: BankAccounts/Create
        public IActionResult Create()
        {
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "FullName");
            ViewData["EmployeeId"] = new SelectList(_context.Employees, "Id", "FullName");
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Id");
            return View();
        }

        // POST: BankAccounts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AccountNumber,AvailBalance,PendingBalance,OpenDate,CloseDate,Status,CustomerId,ProductId,EmployeeId")] BankAccount bankAccount)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bankAccount);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "Address", bankAccount.CustomerId);
            ViewData["EmployeeId"] = new SelectList(_context.Employees, "Id", "FirstName", bankAccount.EmployeeId);
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Id", bankAccount.ProductId);
            return View(bankAccount);
        }

        // GET: BankAccounts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            
            var bankAccount = await _context.BankAccounts.Include(a => a.Customer).Include(a => a.Employee).Include(a => a.Product).FirstOrDefaultAsync(m => m.Id == id); 

            if (bankAccount == null)
            {
                return NotFound();
            }
            
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "Address", bankAccount.CustomerId);
            ViewData["EmployeeId"] = new SelectList(_context.Employees, "Id", "FirstName", bankAccount.EmployeeId);
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Id", bankAccount.ProductId);
            return View(bankAccount);
        }

        // POST: BankAccounts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AccountNumber,AvailBalance,PendingBalance,OpenDate,CloseDate,Status,CustomerId,ProductId,EmployeeId")] BankAccount bankAccount)
        {
            if (id != bankAccount.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bankAccount);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BankAccountExists(bankAccount.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "Address", bankAccount.CustomerId);
            ViewData["EmployeeId"] = new SelectList(_context.Employees, "Id", "FirstName", bankAccount.EmployeeId);
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Id", bankAccount.ProductId);
            return View(bankAccount);
        }

        // GET: BankAccounts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bankAccount = await _context.BankAccounts
                .Include(b => b.Customer)
                .Include(b => b.Employee)
                .Include(b => b.Product)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bankAccount == null)
            {
                return NotFound();
            }

            return View(bankAccount);
        }

        // POST: BankAccounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bankAccount = await _context.BankAccounts.FindAsync(id);
            _context.BankAccounts.Remove(bankAccount);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BankAccountExists(int id)
        {
            return _context.BankAccounts.Any(e => e.Id == id);
        }
    }
}
