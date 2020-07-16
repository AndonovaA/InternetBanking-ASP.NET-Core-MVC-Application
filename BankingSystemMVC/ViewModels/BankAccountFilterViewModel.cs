using BankingSystemMVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingSystemMVC.ViewModels
{
    public class BankAccountFilterViewModel
    {
        public IList<BankAccount> BankAccounts { get; set; }
 
        public SelectList Products { get; set; }
        public string BankAccountProduct { get; set; }

        public string BankAccountEmployeeString { get; set; } 
    }
}
