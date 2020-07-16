using BankingSystemMVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingSystemMVC.ViewModels
{
    public class ProductFilterViewModel
    {
        public IList<Product> Products { get; set; }
        public SelectList Types { get; set; } 
        public string ProductType { get; set; } 

    }
}
