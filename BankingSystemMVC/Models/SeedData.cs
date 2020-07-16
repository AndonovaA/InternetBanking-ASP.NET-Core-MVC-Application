using BankingSystemMVC.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingSystemMVC.Models
{
    public class SeedData
    {
        public static async Task CreateUserRoles(IServiceProvider serviceProvider)
        {
            var RoleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var UserManager = serviceProvider.GetRequiredService<UserManager<AppUser>>();

            IdentityResult roleResult;
            //Adding Admin Role
            var roleCheck = await RoleManager.RoleExistsAsync("Admin");
            if (!roleCheck)
            {
                roleResult = await RoleManager.CreateAsync(new IdentityRole("Admin"));
            }
            roleCheck = await RoleManager.RoleExistsAsync("Employee");
            if (!roleCheck)
            {
                roleResult = await RoleManager.CreateAsync(new IdentityRole("Employee"));
            }
            roleCheck = await RoleManager.RoleExistsAsync("Customer");
            if (!roleCheck)
            {
                roleResult = await RoleManager.CreateAsync(new IdentityRole("Customer"));
            }

            AppUser user = await UserManager.FindByEmailAsync("admin_bank@mkbank.com");
            if (user == null)
            {
                var User = new AppUser();
                User.Email = "admin_bank@mkbank.com";
                User.UserName = "admin_bank@mkbank.com";
                User.Role = "Admin";
                string userPWD = "Admin123";
                IdentityResult chkUser = await UserManager.CreateAsync(User, userPWD);
                //Add default User to Role Admin      
                if (chkUser.Succeeded)
                {
                    var result1 = await UserManager.AddToRoleAsync(User, "Admin");
                }
            }
        }

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BankDbContext( serviceProvider.GetRequiredService<DbContextOptions<BankDbContext>>()))
            {
                CreateUserRoles(serviceProvider).Wait();

                if (context.Customers.Any() || context.BankAccounts.Any() || context.Employees.Any() || context.Products.Any() || context.Transactions.Any())
                {
                    return;
                }

                context.Products.AddRange(
               new Product { Id = "TS", Name = "Topsi за студенти", Type = "Дебитна" },
               new Product { Id = "VISA", Name = "Visa Classic", Type = "Кредитна" },
               new Product { Id = "DMC", Name = "Debit MasterCard", Type = "Дебитна" },
               new Product { Id = "MC", Name = "MasterCard Standard", Type = "Кредитна" },
               new Product { Id = "WAMC", Name = "MasterCard Wizz Air", Type = "Кредитна" },
               new Product { Id = "MAE", Name = "Maestro", Type = "Дебитна" }
               );
                context.SaveChanges();

                context.Customers.AddRange(
                new Customer { BirthDate = new DateTime(1998, 12, 22), FirstName = "Анастасија", LastName = "Андонова", Address = "ул. Орце Николов бр.6", City = "Пехчево", State = "Македонија", Identification= "licnakarta123456789.pdf"},
                new Customer { BirthDate = new DateTime(1997, 5, 6), FirstName = "Марија", LastName = "Станковска", Address = "Даме Груев бр.15", City = "Виница", State = "Македонија", Identification = "pasosh123456789.pdf"},
                new Customer { BirthDate = new DateTime(1992, 8, 4), FirstName = "Бојана", LastName = "Петковска", Address = "Гоце Делчев бр.1", City = "Струмица", State = "Македонија" }
                );
                context.SaveChanges();

                context.Employees.AddRange(
                new Employee { FirstName = "Ангел", LastName = "Ангелковски", StartDate = new DateTime(2001, 11, 1), Title = "Референт", Signature = "angel.jpg"},
                new Employee { FirstName = "Иван", LastName = "Стефановски", StartDate = new DateTime(2019, 2, 1), Title = "Референт", Signature="ivan.jpg"},
                new Employee { FirstName = "Марко", LastName = "Марковски", StartDate = new DateTime(1999, 1, 1), Title = "Референт" }
                );
                context.SaveChanges();

                context.BankAccounts.AddRange(
                new BankAccount { AccountNumber="2243853205959", AvailBalance = 15000, PendingBalance = 15000, OpenDate = new DateTime(2018, 11, 1), CloseDate = new DateTime(2022, 11, 1), Status = "ACTIVE", CustomerId = 1, EmployeeId = 1, ProductId = "TS" },
                new BankAccount { AccountNumber="2369486834632", AvailBalance = 2000, PendingBalance = 2000, OpenDate = new DateTime(2019, 1, 6), CloseDate = new DateTime(2023, 1, 6), Status = "ACTIVE", CustomerId = 1, EmployeeId = 1, ProductId = "VISA" },
                new BankAccount { AccountNumber="2023853532850", AvailBalance = 50599, PendingBalance = 50599, OpenDate = new DateTime(2015, 9, 6), CloseDate = new DateTime(2019, 9, 6), Status = "DORMANT", CustomerId = 2, EmployeeId = 3, ProductId = "MC" },
                new BankAccount { AccountNumber="2805029522355", AvailBalance = 50599, PendingBalance = 50599, OpenDate = new DateTime(2018, 9, 6), CloseDate = new DateTime(2022, 9, 6), Status = "ACTIVE", CustomerId = 3, EmployeeId = 2, ProductId = "DMC" }
                );
                context.SaveChanges();

                context.Transactions.AddRange(
                new Transaction { Amount = -1000, TransDate = new DateTime(2020, 1, 15), TotalBalance = 15235, Type = "Одлив", Receiver = "RAMSTORE Тафталиџе", AccountId = 1},
                new Transaction { Amount = -235, TransDate = new DateTime(2020, 1, 29), TotalBalance = 15000, Type = "Одлив", Receiver = "RAMSTORE Тафталиџе", AccountId = 1 },
                new Transaction { Amount = 50, TransDate = new DateTime(2020, 2, 10), TotalBalance = 15050, Type = "Прилив", Receiver = "тикет добивка", AccountId = 1 }
                );
                context.SaveChanges();
            }
        }
    }
}
