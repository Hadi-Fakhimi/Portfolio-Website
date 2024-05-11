using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Domain.ViewModels.Education
{
    public class CreateOrEditEducationViewModel
    {
        public long Id { get; set; }
        [Display(Name = "عنوان")]
        [MaxLength(50, ErrorMessage = "نمی تواند بیشتر از ۵۰ کاراکتر باشد")]
        [Required(ErrorMessage = "لطفا عنوان وارد نمایید")]
        public string Title { get; set; }
        [Display(Name = "تاریخ شروع")]
        [Required(ErrorMessage = "لطفا تاریخ شروع را وارد نمایید")]
        [MaxLength(4, ErrorMessage = "نمی تواند بیشتر از ۴ کاراکتر باشد")]
        [MinLength(4, ErrorMessage = "نمی تواند کمتر از ۴ کاراکتر باشد")]
        public string StartDate { get; set; }
        [Display(Name = "تاریخ پایان")]
        [Required(ErrorMessage = "لطفا تاریخ پایان را وارد نمایید")]
        [MaxLength(4, ErrorMessage = "نمی تواند بیشتر از ۴ کاراکتر باشد")]
        [MinLength(4, ErrorMessage = "نمی تواند کمتر از ۴ کاراکتر باشد")]
        public string EndDate { get; set; }
        [Display(Name = "توضیحات")]
        [MaxLength(10000, ErrorMessage = "نمی تواند بیشتر از ۱۰۰۰۰ کاراکتر باشد")]
        public string Description { get; set; }
        [Display(Name = "اولویت")]
        public int Order { get; set; }
    }
}
