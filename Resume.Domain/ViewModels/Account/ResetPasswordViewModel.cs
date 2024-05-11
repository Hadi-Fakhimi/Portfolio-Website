using Resume.Domain.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Domain.ViewModels.Account
{
    public class ResetPasswordViewModel:GoogleRecaptchaViewModel
    {
        [Required(ErrorMessage = "لطفا کد فعالساز را وارد کنید")]
        public string EmailActivationCode { get; set; }

        [Display(Name = "کلمه عبور")]
        [Required(ErrorMessage = "لطفا کلمه عبور را وارد کنید")]
        [MaxLength(100, ErrorMessage = "نمی تواند بیشتر از ۱۰۰ کاراکتر باشد")]
        public string Password { get; set; }

        [Display(Name = "تکرارکلمه عبور")]
        [Required(ErrorMessage = "لطفا تکرارکلمه عبور را وارد کنید")]
        [MaxLength(100, ErrorMessage = "نمی تواند بیشتر از ۱۰۰ کاراکتر باشد")]
        [Compare("Password")]
        public string RePassword { get; set; }
    }

    public enum ResetPasswordResult
    {
        Success,
        UserNotFound
    }
}
