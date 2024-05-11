using Resume.Domain.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Domain.ViewModels.Account
{
    public class ForgotPasswordViewModel:GoogleRecaptchaViewModel
    {
        [Display(Name = "ایمیل")]
        [MaxLength(100, ErrorMessage = "نمی تواند بیشتر از ۱۰۰ کاراکتر باشد")]
        [EmailAddress(ErrorMessage = "ایمیل وارد شده معتبر نمی باشد")]
        [Required(ErrorMessage = "لطفا ایمیل را وارد کنید")]
        public string Email { get; set; }
    }
    public enum ForgotPasswordResualt
    {
        UserNotFound,
        Success
    }
}
