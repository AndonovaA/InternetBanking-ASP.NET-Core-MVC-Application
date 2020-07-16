using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankingSystemMVC.Data;
using BankingSystemMVC.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace BankingSystemMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider; 

                try
                {
                    var context = services.GetRequiredService<BankDbContext>();
                    context.Database.Migrate();
                    SeedData.Initialize(services);

                    var bankacc = context.BankAccounts;
                    foreach( BankAccount ba in bankacc)
                    {
                        if(ba.CloseDate < DateTime.Now && ba.Status == "ACTIVE")
                        {
                            ba.Status = "DORMANT";
                            context.Update(ba);
                        }
                    }
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred seeding the DB.");
                }
            }
            host.Run();

            
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
