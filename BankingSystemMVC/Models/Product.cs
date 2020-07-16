using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BankingSystemMVC.Models
{
    public class Product
    {
        [Key]
        [Display(Name = "ИД")]
        public string Id { get; set; } 

        [Required]
        [Display(Name = "Категорија")]
        public string Name { get; set; }

        [Display(Name = "Тип")]
        public string Type { get; set; }

        //many-to-one
        [Display(Name = "Сметки")] 
        public ICollection<BankAccount> Accounts { get; set; }
    }
}
