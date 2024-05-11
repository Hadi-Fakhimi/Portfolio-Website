using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Domain.Models
{
    public class Portfolio
    {
        [Key]
        public long Id { get; set; }
        [Display(Name = "عنوان")]
        [MaxLength(100, ErrorMessage = "{نمیتواند بیشتر از {۱} کاراکتر باشد {0")]
        [Required(ErrorMessage = "لطفا{۰} وارد نمایید")]
        public string Title { get; set; }
        [Display(Name = "لینک")]
        [MaxLength(1000, ErrorMessage = "{نمیتواند بیشتر از {۱} کاراکتر باشد {0")]
        public string Link { get; set; }
        [Display(Name = "تصویر")]
        [Required(ErrorMessage = "لطفا{۰} وارد نمایید")]
        public string Image { get; set; }
        [Display(Name = "توضیح تصویر")]
        [Required(ErrorMessage = "لطفا{۰} وارد نمایید")]
        public string ImageAlt { get; set; }
        [Display(Name = "اولویت")]
        public int Order { get; set; } = 0;



        public long PortfolioCategoryId { get; set; }
        public PortfolioCategory PortfolioCategory { get; set; }

    }
}
