using Resume.Domain.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Domain.ViewModels.Account
{
    public class LoginViewModel:GoogleRecaptchaViewModel
    {
        [Display(Name = "ایمیل")]
        [MaxLength(100, ErrorMessage = "نمی تواند بیشتر از ۱۰۰ کاراکتر باشد")]
        [EmailAddress(ErrorMessage = "ایمیل وارد شده معتبر نمی باشد")]
        [Required(ErrorMessage = "لطفا ایمیل را وارد کنید")]
        public string Email { get; set; }

        [Display(Name = "کلمه عبور")]
        [Required(ErrorMessage = "لطفا کلمه عبور را وارد کنید")]
        [MaxLength(100, ErrorMessage = "نمی تواند بیشتر از ۱۰۰ کاراکتر باشد")]
        public string Password { get; set; }

        public bool RememberMe { get; set; }

    }

    public enum LoginResult
    {
        Success,
        UserNotFound,
        EmailNotActivated
    }
}
