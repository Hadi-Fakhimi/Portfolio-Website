using System.ComponentModel.DataAnnotations;

namespace Resume.Domain.ViewModels.Message
{
    public class MessageViewModel
    {
        public long Id { get; set; }
        [Display(Name = "نام و نام خانوادگی")]
        [Required(ErrorMessage = "لطفا نام و نام خانوادگی را وارد کنید")]
        [MaxLength(100, ErrorMessage = "نمی تواند بیشتر از ۱۰۰ کاراکتر با شد")]
        public string Name { get; set; }
        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "لطفا ایمیل را وارد کنید")]
        [MaxLength(250, ErrorMessage = "نمی تواند بیشتر از ۲۵۰ کاراکتر با شد")]
        [EmailAddress(ErrorMessage = "لطفا ایمیل را وارد کنید")]
        public string Email { get; set; }
        [Display(Name = "پیام")]
        [Required(ErrorMessage = "لطفا پیام خود را وارد کنید")]
        [MaxLength(300, ErrorMessage = "نمی تواند بیشتر از ۳۰۰ کاراکتر با شد")]
        public string MessageContact { get; set; }
    }
}
