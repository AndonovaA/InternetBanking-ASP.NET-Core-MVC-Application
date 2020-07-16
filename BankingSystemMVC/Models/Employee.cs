using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BankingSystemMVC.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Име")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Презиме")]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Почетен датум")]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Завршен датум")]
        public DateTime? EndDate { get; set; }

        [Required]
        [Display(Name = "Титула")]
        public string Title { get; set; }

        [Display(Name = "Потпис")]
        public string Signature { get; set; }

        //get full name
        [Display(Name = "Име и презиме")]
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

        //one-to-many with Account
        [Display(Name = "Креирани сметки")]
        public ICollection<BankAccount> Accounts { get; set; }

        //one-to-many with Transaction
        [Display(Name = "Направени трансакции")]
        public ICollection<Transaction> Transactions { get; set; }

        // one/zero-to-one with AppUser 
        public virtual AppUser AppUser { get; set; }
    }
}
