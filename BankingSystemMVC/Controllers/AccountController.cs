using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankingSystemMVC.Data;
using BankingSystemMVC.Models;
using BankingSystemMVC.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BankingSystemMVC.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private UserManager<AppUser> userManager;
        private SignInManager<AppUser> signInManager;
        private IPasswordHasher<AppUser> passwordHasher;
        private IPasswordValidator<AppUser> passwordValidator;
        private IUserValidator<AppUser> userValidator;
        private readonly BankDbContext _context;

        public AccountController(UserManager<AppUser> userMgr, SignInManager<AppUser> signinMgr, IPasswordHasher<AppUser> passwordHash, IPasswordValidator<AppUser> passwordVal, IUserValidator<AppUser> userValid, BankDbContext context)
        {
            userManager = userMgr;
            signInManager = signinMgr;
            passwordHasher = passwordHash;
            passwordValidator = passwordVal;
            userValidator = userValid;
            _context = context;
        }

        [AllowAnonymous]
        public IActionResult Login(string returnUrl)
        {
            LoginViewModel login = new LoginViewModel();
            login.ReturnUrl = returnUrl;
            return View(login);
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel login)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = await userManager.FindByEmailAsync(login.Email);
                if (appUser != null)
                {
                    await signInManager.SignOutAsync();
                    Microsoft.AspNetCore.Identity.SignInResult result = await signInManager.PasswordSignInAsync(appUser, login.Password, false, false);
                    if (result.Succeeded)
                    {
                        if ((await userManager.IsInRoleAsync(appUser, "Admin")))
                        {
                            //return Redirect(login.ReturnUrl ?? "/");
                            return RedirectToAction("Index", "Home", null);
                        }
                        if ((await userManager.IsInRoleAsync(appUser, "Employee")))
                        {
                            //return RedirectToAction("Courses", "Teacher", new { id = appUser.TeacherId });
                            return Redirect(login.ReturnUrl ?? "/");
                        }
                        if ((await userManager.IsInRoleAsync(appUser, "Customer")))
                        {
                            //return RedirectToAction("Enrollments", "Student", new { id = appUser.StudentId });
                            return Redirect(login.ReturnUrl ?? "/");
                        }
                    }
                }
                ModelState.AddModelError(nameof(login.Email), "Login Failed: Invalid Email or password");
            }
            return View(login);
        }

        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home", null);
        }

        [Authorize]
        public async Task<IActionResult> UserInfo()
        {
            AppUser curruser = await userManager.GetUserAsync(User);
            string userDetails = curruser.UserName;
            string role = "Администратор";
            if (curruser.EmployeeId != null)
            {
                Employee employee = await _context.Employees.FindAsync(curruser.EmployeeId);
                userDetails = employee.FullName + ", " + employee.Title;
                role = "Вработен";
            }
            else if (curruser.CustomerId != null)
            {
                Customer customer = await _context.Customers.FindAsync(curruser.CustomerId);
                userDetails = customer.FullName + ", " + customer.BirthDate; 
                role = "Клиент";
            }
            UserInfoViewModel userInfoViewModel = new UserInfoViewModel
            {
                UserDetails = userDetails,
                Role = role,
                Id = curruser.Id,
                PasswordHash = curruser.PasswordHash,
                PhoneNumber = curruser.PhoneNumber,
                Email = curruser.Email
            };
            return View(userInfoViewModel);
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UserInfo(UserInfoViewModel entry)
        {
            AppUser user = await userManager.GetUserAsync(User);
            if (user != null)
            {
                IdentityResult validPass = null;
                if (!string.IsNullOrEmpty(entry.NewPassword))
                {
                    validPass = await passwordValidator.ValidateAsync(userManager, user, entry.NewPassword);
                    if (validPass.Succeeded)
                        user.PasswordHash = passwordHasher.HashPassword(user, entry.NewPassword);
                    else
                        Errors(validPass);
                }
                else
                {
                    //user wants to change the phone number only
                    user.PhoneNumber = entry.PhoneNumber;
                    IdentityResult result = await userManager.UpdateAsync(user);
                    if (result.Succeeded)
                        return RedirectToAction(nameof(UserInfo));
                    else
                        Errors(result);
                }   

                if (!string.IsNullOrEmpty(entry.NewPassword) && validPass.Succeeded)
                {
                    //user can change not only the phone number but also the password
                    user.PhoneNumber = entry.PhoneNumber;
                    IdentityResult result = await userManager.UpdateAsync(user);
                    if (result.Succeeded)
                        return RedirectToAction(nameof(UserInfo));
                    else
                        Errors(result);
                }
            }
            return View(user);
        }

        public IActionResult AccessDenied()
        {
            return View();
        }

        private void Errors(IdentityResult result)
        {
            foreach (IdentityError error in result.Errors)
                ModelState.AddModelError("", error.Description);
        }
    }
}