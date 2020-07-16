using BankingSystemMVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingSystemMVC.ViewModels
{
    public class EmployeeFilterViewModel
    {
        public IList<Employee> Employees { get; set; }

        public SelectList Titles { get; set; }
        public string EmployeeTitle { get; set; }
    }
}
