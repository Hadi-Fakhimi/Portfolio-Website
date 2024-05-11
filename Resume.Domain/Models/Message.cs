using System.ComponentModel.DataAnnotations;

namespace Resume.Domain.Models
{
    public class Message
    {
        [Key]
        public long Id { get; set; }
        [Display(Name = "نام و نام خانوادگی")]
        [Required(ErrorMessage = "لطفا{۰} وارد نمایید")]
        [MaxLength(100, ErrorMessage = "{نمیتواند بیشتر از {۱} کاراکتر باشد {0")]
        public string Name { get; set; }
        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "لطفا{۰} وارد نمایید")]
        [MaxLength(250, ErrorMessage = "{نمیتواند بیشتر از {۱} کاراکتر باشد {0")]
        [EmailAddress(ErrorMessage ="لطفا ایمیل را وارد کنید")]
        public string Email { get; set; }
        [Display(Name = "پیام")]
        [Required(ErrorMessage = "لطفا{۰} وارد نمایید")]
        [MaxLength(300, ErrorMessage = "{نمیتواند بیشتر از {۱} کاراکتر باشد {0")]
        public string MessageContact { get; set; }

    }
}
