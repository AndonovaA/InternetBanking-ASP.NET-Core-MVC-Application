using BankingSystemMVC.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingSystemMVC.Data
{
    public class BankDbContext : IdentityDbContext<AppUser>
    {
        public BankDbContext(DbContextOptions<BankDbContext> options)
            : base(options)
        {
        }

        public DbSet<BankAccount> BankAccounts { get; set; } 
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Transaction> Transactions { get; set; }  


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<BankAccount>()
                .HasOne<Customer>(p => p.Customer)
                .WithMany(p => p.Accounts)
                .HasForeignKey(p => p.CustomerId);

            builder.Entity<BankAccount>()
                .HasOne<Product>(p => p.Product)
                .WithMany(p => p.Accounts)
                .HasForeignKey(p => p.ProductId);

            builder.Entity<Transaction>()
                .HasOne<BankAccount>(p => p.Account)
                .WithMany(p => p.Transactions)
                .HasForeignKey(p => p.AccountId);
   
            builder.Entity<BankAccount>()
                .HasOne<Employee>(p => p.Employee)
                .WithMany(p => p.Accounts)
                .HasForeignKey(p => p.EmployeeId);

            builder.Entity<Transaction>()
                .HasOne<Employee>(p => p.Employee)
                .WithMany(p => p.Transactions)
                .HasForeignKey(p => p.EmployeeId).OnDelete(DeleteBehavior.Restrict);

            builder.Entity<AppUser>()
               .HasOne(p => p.Customer)
               .WithOne(p => p.AppUser);

            builder.Entity<AppUser>()
               .HasOne<Employee>(p => p.Employee)
               .WithOne(p => p.AppUser);
        }
    }
}
