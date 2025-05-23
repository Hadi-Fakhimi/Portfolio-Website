using Resume_V2.Application.DTOs.Common;
using System.ComponentModel.DataAnnotations;

namespace Resume_V2.Application.DTOs
{
    public class LoginViewModel:GoogleRecaptchaViewModel
    {
        [Display(Name = "ایمیل")]
        [MaxLength(100, ErrorMessage = "نمی تواند بیشتر از {1} کاراکتر باشد {0}.")]
        [EmailAddress(ErrorMessage = "ایمیل وارد شده معتبر نمی باشد")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Email { get; set; }

        [Display(Name = "کلمه عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(100, ErrorMessage = "نمی تواند بیشتر از {1} کاراکتر باشد {0}.")]
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
