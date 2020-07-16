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
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;

namespace BankingSystemMVC.Controllers
{
    [Authorize(Roles = "Admin")]
    public class EmployeesController : Controller
    {
        private readonly BankDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private UserManager<AppUser> userManager;


        public EmployeesController(BankDbContext context, IWebHostEnvironment webHostEnvironment, UserManager<AppUser> um)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
            userManager = um;
        }

        // GET: Employees
        public async Task<IActionResult> Index(string employeeTitle)
        {
            IQueryable<string> titleQuery = _context.Employees.Select(c => c.Title).Distinct();
            IQueryable<Employee> employees = _context.Employees.AsQueryable();

            if (employeeTitle != null)
            {
                employees = employees.Where(c => c.Title.Equals(employeeTitle));
            }

            EmployeeFilterViewModel vm = new EmployeeFilterViewModel
            {
                Titles = new SelectList(await titleQuery.ToListAsync()),
                Employees = await employees.ToListAsync()
            };
            return View(vm);
        }

        // GET: Employees/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees
                .FirstOrDefaultAsync(m => m.Id == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // GET: Employees/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Employees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EmployeeFormViewModel vm)
        {
            string uniqueFileName = UploadedFile(vm);

            Employee employee = new Employee
            {
                FirstName = vm.FirstName,
                LastName = vm.LastName,
                StartDate = vm.StartDate,
                EndDate = vm.EndDate,
                Title = vm.Title,
                Signature = uniqueFileName,
                Accounts = vm.Accounts,
                Transactions = vm.Transactions,
                AppUser = vm.AppUser
            };
            _context.Add(employee);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        // GET: Employees/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }

            EmployeeFormViewModel vm = new EmployeeFormViewModel
            {
                Id = employee.Id,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                StartDate = employee.StartDate,
                EndDate = employee.EndDate,
                Title = employee.Title,
                Accounts = employee.Accounts,
                Transactions = employee.Transactions,
                AppUser = employee.AppUser
            };
            return View(vm);
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, EmployeeFormViewModel vm)
        {
            if (id != vm.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    string uniqueFileName = UploadedFile(vm);
                    Employee employee = new Employee
                    {
                        Id = vm.Id,
                        FirstName = vm.FirstName,
                        LastName = vm.LastName,
                        StartDate = vm.StartDate,
                        EndDate = vm.EndDate,
                        Title = vm.Title,
                        Accounts = vm.Accounts,
                        Transactions = vm.Transactions,
                        AppUser = vm.AppUser,
                        Signature = uniqueFileName
                    };

                    _context.Update(employee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeExists(vm.Id))
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
            return View(vm);
        }

        // GET: Employees/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees.Include(e=>e.AppUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            AppUser user = _context.Users.Where(u => u.EmployeeId == id).FirstOrDefault();
            if (user != null)
            {
                IdentityResult result = await userManager.DeleteAsync(user);
                if (result.Succeeded)
                {
                    _context.Employees.Remove(employee);
                }
            }
            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeExists(int id)
        {
            return _context.Employees.Any(e => e.Id == id);
        }

        private string UploadedFile(EmployeeFormViewModel model)
        {
            string uniqueFileName = null;

            if (model.Signature != null)
            {
                string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "identification");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + Path.GetFileName(model.Signature.FileName);
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.Signature.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }
    }
}
