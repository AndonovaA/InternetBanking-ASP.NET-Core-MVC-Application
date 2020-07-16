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
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace BankingSystemMVC.Controllers
{
    [Authorize(Roles = "Employee")]
    public class EmployeeController : Controller
    {
        private readonly BankDbContext _context;
        private UserManager<AppUser> userManager;
        private IPasswordHasher<AppUser> passwordHasher;
        private IPasswordValidator<AppUser> passwordValidator;
        private IUserValidator<AppUser> userValidator;
        private readonly IWebHostEnvironment _webHostEnvironment;


        public EmployeeController(BankDbContext context, UserManager<AppUser> manager, IPasswordHasher<AppUser> passwordHash, IPasswordValidator<AppUser> passwordVal, IUserValidator<AppUser> userValid, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            userManager = manager;
            passwordHasher = passwordHash;
            passwordValidator = passwordVal;
            userValidator = userValid;
            _webHostEnvironment = webHostEnvironment;
        }

        // GET: Employee/EmployeeDetails/{employeeId} 
        public async Task<IActionResult> EmployeeDetails(int id)
        {
            AppUser loggedUser = await userManager.GetUserAsync(User);
            if (loggedUser.EmployeeId != id)
            {
                return RedirectToAction("AccessDenied", "Account", null);
            }

            var employee = await _context.Employees.Include(e=>e.Accounts).Include(e=>e.Transactions).Where(c => c.Id == id).FirstOrDefaultAsync(); 

            if (employee != null)
                ViewData["EmployeeName"] = employee.FullName;
            else
                return NotFound();

            return View(employee);
        }

        // GET: Employee/EmployeeClients/{employeeId} 
        public async Task<IActionResult> EmployeeClients(int id)
        {
            AppUser loggedUser = await userManager.GetUserAsync(User);
            if (loggedUser.EmployeeId != id)
            {
                return RedirectToAction("AccessDenied", "Account", null);
            }

            var customers = _context.Customers.Include(c=>c.Accounts);

            ViewData["EmployeeId"] = loggedUser.EmployeeId;
            return View(customers);
        }

        // GET: Employee/EmployeeProducts/{employeeId} 
        public async Task<IActionResult> EmployeeProducts(int id) 
        {
            AppUser loggedUser = await userManager.GetUserAsync(User);
            if (loggedUser.EmployeeId != id)
            {
                return RedirectToAction("AccessDenied", "Account", null);
            }

            var products = _context.Products.Include(c => c.Accounts);

            ViewData["EmployeeId"] = loggedUser.EmployeeId;
            return View(products);
        }

        // GET: Employee/CreateCustomer/{employeeId}
        public async Task<IActionResult> CreateCustomer(int id) 
        {
            AppUser loggedUser = await userManager.GetUserAsync(User);
            if (loggedUser.EmployeeId != id)
            {
                return RedirectToAction("AccessDenied", "Account", null);
            }

            ViewData["EmployeeId"] = loggedUser.EmployeeId;

            return View();
        }

        // POST: Employee/CreateCustomer   
        [HttpPost]
        [ValidateAntiForgeryToken] 
        public async Task<IActionResult> CreateCustomer(CustomerFormViewModel vm)
        {
            AppUser loggedUser = await userManager.GetUserAsync(User);

            string uniqueFileName = UploadedFile(vm);
            Customer customer = new Customer
            {
                FirstName = vm.FirstName,
                LastName = vm.LastName,
                Identification = uniqueFileName,
                BirthDate = vm.BirthDate,
                Address = vm.Address,
                City = vm.City,
                State = vm.State,
                Accounts = vm.Accounts,
                AppUser = vm.AppUser
            };
            _context.Add(customer);
            await _context.SaveChangesAsync();

            return RedirectToAction("CreateBankAccount", "Employee", new { emId = loggedUser.EmployeeId }); 
        }

        // GET: Employee/EmployeeClients/EditCustomer/{?customerId}{employeeId}
        public async Task<IActionResult> EditCustomer(int? id, int emId)
        {
            AppUser loggedUser = await userManager.GetUserAsync(User);
            if (loggedUser.EmployeeId != emId)
            {
                return RedirectToAction("AccessDenied", "Account", null);
            }

            if (id == null)
            {
                return NotFound(); 
            }

            var customer = await _context.Customers.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }

            ViewData["EmployeeId"] = loggedUser.EmployeeId;

            CustomerFormViewModel vm = new CustomerFormViewModel
            {
                Id = customer.Id,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                BirthDate = customer.BirthDate,
                Address = customer.Address,
                City = customer.City,
                State = customer.State,
                Accounts = customer.Accounts,
                AppUser = customer.AppUser
            };
            return View(vm);
        }

        // POST: Employee/EmployeeClients/EditCustomer
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditCustomer(int id, CustomerFormViewModel vm)
        {
            AppUser loggedUser = await userManager.GetUserAsync(User);

            if (id != vm.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            { 
                try
                {
                    string uniqueFileName = UploadedFile(vm);
                    Customer customer = new Customer
                    {
                        Id = vm.Id,
                        FirstName = vm.FirstName,
                        LastName = vm.LastName,
                        Identification = uniqueFileName, 
                        BirthDate = vm.BirthDate,
                        Address = vm.Address,
                        City = vm.City,
                        State = vm.State,
                        Accounts = vm.Accounts,
                        AppUser = vm.AppUser
                    };
                    _context.Update(customer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerExists(vm.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return LocalRedirect("/Employee/EmployeeClients/"+ loggedUser.EmployeeId);
            }
            return View(vm);
        }


        // GET: Employee/EmployeeClients/AccountDetails/{bankAccountId}{employeeId} 
        public async Task<IActionResult> AccountDetails(int id, int emId) 
        {
            AppUser loggedUser = await userManager.GetUserAsync(User);
            if (loggedUser.EmployeeId != emId)
            {
                return RedirectToAction("AccessDenied", "Account", null);
            }

            var account = await _context.BankAccounts.Include(b => b.Customer).Include(b => b.Product).Include(b => b.Employee).Where(c => c.Id == id).FirstOrDefaultAsync();

            if (account == null)
                return NotFound();

            ViewData["EmployeeId"] = loggedUser.EmployeeId;
            return View(account);
        }

        // GET: Employee/EmployeeClients/AccountDetails/AccountReport
        public async Task<IActionResult> AccountReport(int id, int emId, DateTime startDate, DateTime endDate)
        {
            AppUser loggedUser = await userManager.GetUserAsync(User);
            if (loggedUser.EmployeeId != emId)
            {
                return RedirectToAction("AccessDenied", "Account", null);
            }

            IQueryable<Transaction> transactions = _context.Transactions.Include(t => t.Account).Where(t => t.AccountId == id).AsQueryable();

            if (!transactions.ToList().Any())
                return RedirectToAction("AccountDetails", "Employee", new { id, emId = loggedUser.EmployeeId }); 

            DateTime temp = new DateTime(01, 1, 0001); //null
            if (startDate != temp && endDate != temp)
            {
                transactions = transactions.Where(t => t.TransDate >= startDate && t.TransDate <= endDate);
            }

            AccountReportViewModel vm = new AccountReportViewModel
            {
                Transactions = await transactions.ToListAsync(),
                BankAccount = await _context.BankAccounts.FindAsync(id)
            };

            ViewData["EmployeeId"] = loggedUser.EmployeeId;
            ViewData["AccountId"] = id;
            return View(vm);
        }

        // GET: Employee/EmployeeClients/CreateBankAccount/{employeeId}
        public async Task<IActionResult> CreateBankAccount(int emId) 
        {
            AppUser loggedUser = await userManager.GetUserAsync(User);
            if (loggedUser.EmployeeId != emId)
            {
                return RedirectToAction("AccessDenied", "Account", null);
            }

            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "FullName");
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Id");
            ViewData["emId"] = loggedUser.EmployeeId;

            return View();
        }

        // POST: Employee/EmployeeClients/CreateBankAccount
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateBankAccount([Bind("AccountNumber,AvailBalance,PendingBalance,OpenDate,CloseDate,Status,CustomerId,ProductId,EmployeeId")] BankAccount bankAccount)
        {
            AppUser loggedUser = await userManager.GetUserAsync(User);
            if (ModelState.IsValid)
            {
                _context.Add(bankAccount); 
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(EmployeeClients), new { id = loggedUser.EmployeeId });
            }
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "Address", bankAccount.CustomerId);
            ViewData["EmployeeId"] = new SelectList(_context.Employees, "Id", "FirstName", bankAccount.EmployeeId);
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Id", bankAccount.ProductId);
            return View(bankAccount);
        }

        // GET: Employee/EmployeeClients/AccountDetails/DeactivateBankAccount/
        public async Task<IActionResult> DeactivateBankAccount(int id, int emId)  
        {
            AppUser loggedUser = await userManager.GetUserAsync(User);
            if (loggedUser.EmployeeId != emId)
            {
                return RedirectToAction("AccessDenied", "Account", null);
            }

            var bankAcc = await _context.BankAccounts.FindAsync(id);
            if (bankAcc != null)
            {
                if (bankAcc.Status == "ACTIVE")
                {
                    bankAcc.Status = "DORMANT";
                    bankAcc.CloseDate = DateTime.Now;
                }
                else
                {
                    bankAcc.Status = "ACTIVE";
                    bankAcc.CloseDate = bankAcc.CloseDate.AddYears(4);
                }

                _context.Update(bankAcc);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("AccountDetails", "Employee", new { id = id, emId = loggedUser.EmployeeId });
        }

        // GET: Employee/MakeTransaction/{employeeId}
        public async Task<IActionResult> MakeTransaction(int emId)
        {
            AppUser loggedUser = await userManager.GetUserAsync(User);
            if (loggedUser.EmployeeId != emId)
            {
                return RedirectToAction("AccessDenied", "Account", null);
            }

            ViewData["Type"] = new SelectList(new List<SelectListItem>
                {
                    new SelectListItem { Text = "Прилив", Value = "Прилив"},
                    new SelectListItem { Text = "Одлив", Value = "Одлив"},
                }, "Value", "Text");
            ViewData["AccountId"] = new SelectList(_context.BankAccounts, "Id", "AccountNumber");
            ViewData["EmployeeId"] = loggedUser.EmployeeId;

            return View();
        }

        // POST: Employee/MakeTransaction
        [HttpPost]
        [ValidateAntiForgeryToken] 
        public async Task<IActionResult> MakeTransaction(float Amount, DateTime TransDate, string Type, string Receiver, string AccountNo, int EmployeeId)
        {
            AppUser loggedUser = await userManager.GetUserAsync(User);

            //We have the AccountNumber so we will find the AccountId
            var acc = _context.BankAccounts.Where(a => a.AccountNumber.Equals(AccountNo)).FirstOrDefault();
            if(acc == null)
                return RedirectToAction(nameof(MakeTransaction), new { emId = loggedUser.EmployeeId });

            Transaction transaction = new Transaction
            {
                Amount=Amount,
                TransDate=TransDate,
                Type=Type,
                Receiver=Receiver,
                Account = acc,
                AccountId = acc.Id,
                EmployeeId = EmployeeId
            };
            //Calculate the TotalBalance and update the transaction
            transaction.TotalBalance = acc.AvailBalance + transaction.Amount;

            if (ModelState.IsValid)
            {
                _context.Add(transaction);
                //Update the AvailBalance and PendingBalance for that BankAccount
                acc.AvailBalance = transaction.TotalBalance;
                acc.PendingBalance = transaction.TotalBalance;
                _context.Update(acc); 
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(AccountDetails), new {id=transaction.AccountId, emId = loggedUser.EmployeeId}); 
            }
            ViewData["Type"] = new SelectList(new List<SelectListItem>
                {
                    new SelectListItem { Text = "Прилив", Value = "Прилив"},
                    new SelectListItem { Text = "Одлив", Value = "Одлив"},
                }, "Value", "Text");

            ViewData["EmployeeId"] = loggedUser.EmployeeId;

            return RedirectToAction(nameof(MakeTransaction), new { emId = loggedUser.EmployeeId});
        }


        // GET: Employee/EmployeeClients/CustomerProfile
        public async Task<IActionResult> CustomerProfile(int customerId, int emId) 
        {
            AppUser loggedUser = await userManager.GetUserAsync(User);
            if (loggedUser.EmployeeId != emId)
            {
                return RedirectToAction("AccessDenied", "Account", null);
            }

            AppUser user = userManager.Users.FirstOrDefault(u => u.CustomerId == customerId);
            Customer customer = _context.Customers.Where(s => s.Id == customerId).FirstOrDefault();
            if (customer != null)
            {
                ViewData["FullNameId"] = customer.FullName;
                ViewData["CustomerId"] = customer.Id;
                ViewData["EmployeeId"] = loggedUser.EmployeeId; 
            }
            if (user != null)
                return View(user);
            else
                return View(null);
        }

        [HttpPost]
        public async Task<IActionResult> CustomerProfile(int customerId, string email, string password, string phoneNumber)
        {
            AppUser loggedUser = await userManager.GetUserAsync(User);
            AppUser user = userManager.Users.FirstOrDefault(u => u.CustomerId == customerId);
            if (user != null)
            {
                IdentityResult validUser = null;
                IdentityResult validPass = null;

                user.Email = email;
                user.UserName = email;
                user.PhoneNumber = phoneNumber;

                if (string.IsNullOrEmpty(email))
                    ModelState.AddModelError("", "Email cannot be empty");

                validUser = await userValidator.ValidateAsync(userManager, user);
                if (!validUser.Succeeded)
                    Errors(validUser);

                if (!string.IsNullOrEmpty(password))
                {
                    validPass = await passwordValidator.ValidateAsync(userManager, user, password);
                    if (validPass.Succeeded)
                        user.PasswordHash = passwordHasher.HashPassword(user, password);
                    else
                        Errors(validPass);
                }

                if (validUser != null && validUser.Succeeded && (string.IsNullOrEmpty(password) || validPass.Succeeded))
                {
                    IdentityResult result = await userManager.UpdateAsync(user);
                    if (result.Succeeded)
                        return RedirectToAction(nameof(CustomerProfile), new { customerId, emId = loggedUser.EmployeeId });
                    else
                        Errors(result);
                }
            }
            else
            {
                AppUser newuser = new AppUser();
                IdentityResult validUser = null;
                IdentityResult validPass = null;

                newuser.Email = email;
                newuser.UserName = email;
                newuser.PhoneNumber = phoneNumber;
                newuser.CustomerId = customerId;
                newuser.Role = "Customer";

                if (string.IsNullOrEmpty(email))
                    ModelState.AddModelError("", "Email cannot be empty");

                validUser = await userValidator.ValidateAsync(userManager, newuser);
                if (!validUser.Succeeded)
                    Errors(validUser);

                if (!string.IsNullOrEmpty(password))
                {
                    validPass = await passwordValidator.ValidateAsync(userManager, newuser, password);
                    if (validPass.Succeeded)
                        newuser.PasswordHash = passwordHasher.HashPassword(newuser, password);
                    else
                        Errors(validPass);
                }
                else
                    ModelState.AddModelError("", "Password cannot be empty");

                if (validUser != null && validUser.Succeeded && validPass != null && validPass.Succeeded)
                {
                    IdentityResult result = await userManager.CreateAsync(newuser, password);
                    if (result.Succeeded)
                    {
                        await userManager.AddToRoleAsync(newuser, "Customer");
                        return RedirectToAction(nameof(CustomerProfile), new { customerId, emId=loggedUser.EmployeeId });
                    }
                    else
                        Errors(result);
                }
                user = newuser;
            }
            Customer customer = _context.Customers.Where(s => s.Id == customerId).FirstOrDefault();
            if (customer != null)
            {
                ViewData["FullNameId"] = customer.FullName;
                ViewData["CustomerId"] = customer.Id;
            }
            return View(user);
        }

        private bool EmployeeExists(int id)
        {
            return _context.Employees.Any(e => e.Id == id);
        }
        private bool CustomerExists(int id)
        {
            return _context.Customers.Any(e => e.Id == id);
        }
        private void Errors(IdentityResult result)
        {
            foreach (IdentityError error in result.Errors)
                ModelState.AddModelError("", error.Description);
        }

        private string UploadedFile(CustomerFormViewModel model)
        {
            string uniqueFileName = null;

            if (model.Identification != null)
            {
                string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "identification");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + Path.GetFileName(model.Identification.FileName);
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.Identification.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }
    }
}