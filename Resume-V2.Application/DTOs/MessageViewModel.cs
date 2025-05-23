using Resume_V2.Application.DTOs.Common;
using System.ComponentModel.DataAnnotations;

namespace Resume_V2.Application.DTOs
{
    public class MessageViewModel:GoogleRecaptchaViewModel
    {
        [Display(Name = "نام و نام خانوادگی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(100, ErrorMessage = "نمی تواند بیشتر از {1} کاراکتر باشد {0}.")]
        public string Name { get; set; }
        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(100, ErrorMessage = "نمی تواند بیشتر از {1} کاراکتر باشد {0}.")]
        public string Title { get; set; }
        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(250, ErrorMessage = "نمی تواند بیشتر از {1} کاراکتر باشد {0}.")]
        [EmailAddress(ErrorMessage = "لطفا ایمیل را وارد کنید")]
        public string Email { get; set; }
        [Display(Name = "پیام")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(300, ErrorMessage = "نمی تواند بیشتر از {1} کاراکتر باشد {0}.")]
        public string MessageContact { get; set; }
    }
}
