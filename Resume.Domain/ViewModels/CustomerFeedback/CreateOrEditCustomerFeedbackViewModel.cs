using System.ComponentModel.DataAnnotations;

namespace Resume.Domain.ViewModels.CustomerFeedback
{
    public class CreateOrEditCustomerFeedbackViewModel
    {
        public int Id { get; set; }
        [Display(Name = "آواتار")]
        public string Avatar { get; set; }
        [Display(Name = "نام")]
        [Required(ErrorMessage = "لطفا نام را وارد کنید")]
        [MaxLength(100, ErrorMessage = "نمی تواند بیشتر از ۱۰۰ کاراکتر باشد")]
        public string Name { get; set; }
        [Display(Name = "توضیحات")]
        [Required(ErrorMessage = "لطفا توضیحات را وارد کنید")]
        [MaxLength(100, ErrorMessage = "نمی تواند بیشتر از ۱۰۰ کاراکتر باشد")]
        public string Description { get; set; }
        [Display(Name = "اولویت")]
        public int Order { get; set; }
        [Display(Name = "در مورد شغل")]
        [Required(ErrorMessage = "لطفا در مورد شغل را وارد کنید")]
        [MaxLength(100, ErrorMessage = "نمی تواند بیشتر از ۱۰۰ کاراکتر باشد")]
        public string AboutJob { get; set; }
    }
}
