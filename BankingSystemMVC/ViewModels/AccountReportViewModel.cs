using BankingSystemMVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingSystemMVC.ViewModels
{
    public class AccountReportViewModel
    {
        public IList<Transaction> Transactions { get; set; }
        public BankAccount BankAccount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
