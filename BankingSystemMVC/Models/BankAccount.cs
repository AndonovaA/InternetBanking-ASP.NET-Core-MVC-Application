using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BankingSystemMVC.Models
{
    public class BankAccount
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Трансакциска Сметка")]
        public string AccountNumber { get; set; }

        [Display(Name = "Салдо")]
        public float AvailBalance { get; set; }

        [Display(Name = "Расположливи средства")]
        public float PendingBalance { get; set; } 

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Датум на отворање")]
        public DateTime OpenDate { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Датум на важност")]
        public DateTime CloseDate { get; set; }

        [Display(Name = "Статус")]
        public string Status { get; set; }

        //one-to-one with Customer
        public int CustomerId { get; set; }

        [Display(Name = "Корисник")]
        public Customer Customer { get; set; }

        //one-to-one with Product
        public string ProductId { get; set; }

        [Display(Name = "Категорија")] 
        public Product Product { get; set; }

        //one-to-one with Employee
        public int EmployeeId { get; set; }

        [Display(Name = "Службено лице")]
        public Employee Employee { get; set; }

        //one-to-many with Transaction
        [Display(Name = "Трансакции")]
        public ICollection<Transaction> Transactions { get; set; }
    }
}
