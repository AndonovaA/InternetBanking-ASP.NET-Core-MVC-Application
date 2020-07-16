using BankingSystemMVC.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BankingSystemMVC.ViewModels
{
    public class CustomerFormViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Дата на раѓање")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Required]
        [Display(Name = "Име")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Презиме")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Адреса на живеење")]
        public string Address { get; set; }

        [Required]
        [Display(Name = "Град")]
        public string City { get; set; }

        [Required]
        [Display(Name = "Држава")]
        public string State { get; set; }

        [Display(Name = "Документ за идентификација")]
        public IFormFile Identification { get; set; } 

        //get full name
        [Display(Name = "Име и презиме")]
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

        [NotMapped]
        public string isResident
        {
            get
            {
                if (State.Equals("Македонија"))
                    return "резидент";
                else
                    return "нерезидент";
            }
        }

        //one-to-many 
        [Display(Name = "Сметки")]
        public ICollection<BankAccount> Accounts { get; set; }

        // one/zero-to-one with AppUser 
        public virtual AppUser AppUser { get; set; }
    }
}
