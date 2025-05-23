using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume_V2.Domain.Models
{
    public class Portfolio
    {
        [Key]
        public long Id { get; set; }
        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(100, ErrorMessage = "نمی تواند بیشتر از {1} کاراکتر باشد {0}.")]
        public string Title { get; set; }
        [Display(Name = "لینک")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(1000, ErrorMessage = "نمی تواند بیشتر از {1} کاراکتر باشد {0}.")]
        public string Link { get; set; }
        [Display(Name = "تصویر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Image { get; set; }
        [Display(Name = "توضیح تصویر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string ImageAlt { get; set; }
        [Display(Name = "نام کارفرما")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(100, ErrorMessage = "نمی تواند بیشتر از {1} کاراکتر باشد {0}.")]
        public string ClientName { get; set; }
        [Display(Name = "نام سرویس")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(100, ErrorMessage = "نمی تواند بیشتر از {1} کاراکتر باشد {0}.")]
        public string ServiceName { get; set; }
        [Display(Name = "زمان صرف شده")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(10, ErrorMessage = "نمی تواند بیشتر از {1} کاراکتر باشد {0}.")]
        public string ProjectTime { get; set; }
        [Display(Name = "توضیحات")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [Display(Name = "تصویر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string ImageDesc { get; set; }
        [Display(Name = "اولویت")]
        public int Order { get; set; } = 0;



        public long PortfolioCategoryId { get; set; }
        public PortfolioCategory PortfolioCategory { get; set; }
    }
}
