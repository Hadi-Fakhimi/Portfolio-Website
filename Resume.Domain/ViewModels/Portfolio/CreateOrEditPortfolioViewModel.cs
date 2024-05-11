using Resume.Domain.ViewModels.PortfolioCategory;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Resume.Domain.ViewModels.Portfolio
{
    public class CreateOrEditPortfolioViewModel
    {
        public long Id { get; set; }
        [Display(Name = "عنوان")]
        [MaxLength(100, ErrorMessage = "نمی توانید بیشتر از ۱۰۰ کاراکتر وارد کنید")]
        [Required(ErrorMessage = "لطفا عنوان وارد نمایید")]
        public string Title { get; set; }
        [Display(Name = "لینک")]
        [MaxLength(1000, ErrorMessage = "نمی توانید بیشتر از ۱۰۰ کاراکتر وارد کنید")]
        public string Link { get; set; }
        [Display(Name = "تصویر")]
        [Required(ErrorMessage = "لطفا تصویر وارد نمایید")]
        public string Image { get; set; }
        [Display(Name = "توضیح تصویر")]
        [Required(ErrorMessage = "لطفا توضیح تصویر وارد نمایید")]
        public string ImageAlt { get; set; }
        [Display(Name = "اولویت")]
        public int Order { get; set; }



        public long PortfolioCategoryId { get; set; }
        [NotMapped]
        public List<PortfolioCategoryViewModel> PortfolioCategory { get; set; }
    }
}
