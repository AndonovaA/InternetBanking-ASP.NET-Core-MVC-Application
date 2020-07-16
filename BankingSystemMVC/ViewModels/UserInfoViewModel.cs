using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BankingSystemMVC.ViewModels
{
    public class UserInfoViewModel
    {
        [Display(Name = "Корисник")]
        public string UserDetails { get; set; }
        [Display(Name = "Улога")]
        public string Role { get; set; }
        [Display(Name = "Id корисник")]
        public string Id { get; set; }
        [Display(Name = "Хеширана лозинка")]
        public string PasswordHash { get; set; }
        [Display(Name = "Тел. број")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Email адреса")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Нова лозинка")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Нова лозинка (повторно)")]
        [Compare("NewPassword", ErrorMessage = "Лозинките не се совпаѓаат.")]
        public string ConfirmPassword { get; set; }
    }
}
