using System.ComponentModel.DataAnnotations;

namespace Resume.Domain.ViewModels.PortfolioCategory
{
    public class CreateOrEditPortfolioCategoryViewModel
    {
        public long Id { get; set; }
        [Display(Name = "عنوان")]
        [MaxLength(100, ErrorMessage = "نمی توانید بیشتر از ۱۰۰ کاراکتر وارد کنید")]
        [Required(ErrorMessage = "لطفا عنوان وارد نمایید")]
        public string Title { get; set; }
        [Display(Name = "نام")]
        [MaxLength(100, ErrorMessage = "نمی توانید بیشتر از ۱۰۰ کاراکتر وارد کنید")]
        [Required(ErrorMessage = "لطفا نام وارد نمایید")]
        public string Name { get; set; }
        [Display(Name = "اولویت")]
        public int Order { get; set; }
    }
}
