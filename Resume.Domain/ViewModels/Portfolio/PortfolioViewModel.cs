using System.ComponentModel.DataAnnotations;

namespace Resume.Domain.ViewModels.Portfolio
{
    public class PortfolioViewModel
    {
        [Key]
        public long Id { get; set; }
        [Display(Name = "عنوان")]
        public string Title { get; set; }
        [Display(Name = "لینک")]
        public string Link { get; set; }
        [Display(Name = "تصویر")]
        public string Image { get; set; }
        [Display(Name = "توضیح تصویر")]
        public string ImageAlt { get; set; }
        [Display(Name = "اولویت")]
        public int Order { get; set; } = 0;

        public string PortfolioCategoryName { get; set; }    
    }
}
