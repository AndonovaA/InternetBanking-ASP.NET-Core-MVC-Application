using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BankingSystemMVC.Models
{
    public class AppUser : IdentityUser
    {
        [Display(Name = "Улога")]
        public string Role { get; set; }

        public int? CustomerId { get; set; }
        [Display(Name = "Клиент")]
        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }

        public int? EmployeeId { get; set; }
        [Display(Name = "Вработен")]
        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; } 
    }
}
