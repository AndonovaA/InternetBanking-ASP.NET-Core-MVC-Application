using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BankingSystemMVC.Models
{
    public class Transaction
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Сума")]
        public float Amount { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Датум (д/м/г)")]
        public DateTime TransDate { get; set; }

        [Required]
        [Display(Name = "Биланс")] //состојбата на сметката после трансакцијата
        public float TotalBalance { get; set; }

        [Required]
        [Display(Name = "Тип")]
        public string Type { get; set; } //прилив или одлив

        [Display(Name = "Назив на примач-налогодавач")]
        public string Receiver { get; set; } 

        //one-to-one with Account
        public int AccountId { get; set; }

        [Display(Name = "Сметка")]
        public BankAccount Account { get; set; }

        // one/zero-to-one with Employee 
        public int? EmployeeId { get; set; }

        [Display(Name = "Службено лице")]
        public Employee Employee { get; set; }
    }
}
