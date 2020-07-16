using BankingSystemMVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingSystemMVC.ViewModels
{
    public class CustomerFilterViewModel
    {
        public IList<Customer> Customers { get; set; }

        public SelectList States { get; set; }
        public string CustomerState { get; set; }

    }
}
