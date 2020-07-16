using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankingSystemMVC.Data;
using BankingSystemMVC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BankingSystemMVC.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private UserManager<AppUser> userManager;
        private IPasswordHasher<AppUser> passwordHasher;
        private IPasswordValidator<AppUser> passwordValidator;
        private IUserValidator<AppUser> userValidator;
        private readonly BankDbContext _context;

        public AdminController(UserManager<AppUser> usrMgr, IPasswordHasher<AppUser> passwordHash, IPasswordValidator<AppUser> passwordVal, IUserValidator<AppUser>
userValid, BankDbContext context)
        {
            userManager = usrMgr;
            passwordHasher = passwordHash;
            passwordValidator = passwordVal;
            userValidator = userValid;
            _context = context;
        }

        public IActionResult Index(int? who)
        {
            IQueryable<AppUser> users = userManager.Users.OrderBy(u => u.Email);

                if(who == 2)
                {
                    users = users.Where(u => u.EmployeeId != null);
                }
                else if(who == 3)
                {
                    users = users.Where(u => u.CustomerId != null);
                }
                else
                    users = users.OrderBy(u => u.Role);

            return View(users);
        }

        public IActionResult EmployeeProfile(int employeeId)
        {
            //AppUser user = await userManager.FindByIdAsync(id);
            AppUser user = userManager.Users.FirstOrDefault(u => u.EmployeeId == employeeId);
            Employee employee = _context.Employees.Where(s => s.Id == employeeId).FirstOrDefault();
            if (employee != null)
            {
                ViewData["FullName"] = employee.FullName;
                ViewData["EmployeeId"] = employee.Id;
            }
            if (user != null)
                return View(user);
            else
                return View(null);
        }

        [HttpPost]
        public async Task<IActionResult> EmployeeProfile(int employeeId, string email, string password, string phoneNumber)
        {
            //AppUser user = await userManager.FindByIdAsync(id);
            AppUser user = userManager.Users.FirstOrDefault(u => u.EmployeeId == employeeId);
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
                    {
                        return RedirectToAction(nameof(EmployeeProfile), new { employeeId });
                    }
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
                newuser.EmployeeId = employeeId;
                newuser.Role = "Employee";

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
                        await userManager.AddToRoleAsync(newuser, "Employee");
                        return RedirectToAction(nameof(EmployeeProfile), new { employeeId });
                    } 
                    else
                        Errors(result);
                }
                user = newuser;
            }
            Employee employee = _context.Employees.Where(s => s.Id == employeeId).FirstOrDefault();
            if (employee != null)
            {
                ViewData["FullName"] = employee.FullName;
                ViewData["EmployeeId"] = employee.Id;
            }
            return View(user);
        }

        public IActionResult CustomerProfile(int customerId)
        {
            //AppUser user = await userManager.FindByIdAsync(id);
            AppUser user = userManager.Users.FirstOrDefault(u => u.CustomerId == customerId);
            Customer customer = _context.Customers.Where(s => s.Id == customerId).FirstOrDefault();
            if (customer != null)
            {
                ViewData["FullNameId"] = customer.FullName;
                ViewData["CustomerId"] = customer.Id;
            }
            if (user != null)
                return View(user);
            else
                return View(null);
        }

        [HttpPost]
        public async Task<IActionResult> CustomerProfile(int customerId, string email, string password, string phoneNumber)
        {
            //AppUser user = await userManager.FindByIdAsync(id);
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
                        return RedirectToAction(nameof(CustomerProfile), new { customerId });
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
                        return RedirectToAction(nameof(CustomerProfile), new { customerId });
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

        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            AppUser user = await userManager.FindByIdAsync(id);
            if (user != null)
            {
                IdentityResult result = await userManager.DeleteAsync(user);
                if (result.Succeeded)
                    return RedirectToAction("Index");
                else
                    Errors(result);
            }
            else
                ModelState.AddModelError("", "User Not Found");
            return View("Index", userManager.Users);
        }


        [HttpGet]
        public IActionResult CreateUser() 
        {
            var customers = _context.Customers.Where(c => c.AppUser == null);
            var employees = _context.Employees.Where(c => c.AppUser == null);

            ViewData["CustomerId"] = new SelectList(customers.ToList(), "Id", "FullName");
            ViewData["EmployeeId"] = new SelectList(employees.ToList(), "Id", "FullName");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(string Email, string PhoneNumber, int CustomerId, int EmployeeId, string Password)
        {
            if (Email != null && PhoneNumber != null && Password != null)
            { 
                AppUser user = new AppUser
                {

                    UserName = Email,
                    PhoneNumber = PhoneNumber,
                    Email = Email
                };

            if(CustomerId != 0 && EmployeeId == 0)
            {
                user.CustomerId = CustomerId;
                user.EmployeeId = null;
                user.Role = "Customer";
            }
            if(EmployeeId != 0 && CustomerId == 0)
            {
                user.EmployeeId = EmployeeId;
                user.CustomerId = null;
                user.Role = "Employee";
            }

            IdentityResult result = await userManager.CreateAsync(user, Password);
            if (result.Succeeded)
            {
                if(user.CustomerId != null)
                {
                    await userManager.AddToRoleAsync(user, "Customer");
                }
                else if(user.EmployeeId != null)
                {
                    await userManager.AddToRoleAsync(user, "Employee");
                }
                return RedirectToAction("Index");
            }
            else
            {
                foreach (IdentityError error in result.Errors)
                    ModelState.TryAddModelError(error.Code, error.Description);
            }
          }
        return RedirectToAction("CreateUser");
        }

        private void Errors(IdentityResult result)
        {
            foreach (IdentityError error in result.Errors)
                ModelState.AddModelError("", error.Description);
        }
    }
}