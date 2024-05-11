using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Domain.ViewModels.Experience
{
    public class CreateOrEditExperienceViewModel
    {
        public long Id { get; set; }
        [Display(Name = "عنوان")]
        [MaxLength(50, ErrorMessage = "نمی توانید بیشتر از ۵۰ کاراکتر وارد کنید")]
        [Required(ErrorMessage = "لطفا عنوان وارد نمایید")]
        public string Title { get; set; }
        [Display(Name = "تاریخ شروع")]
        [Required(ErrorMessage = "لطفا تاریخ شروع را وارد نمایید")]
        [MaxLength(4, ErrorMessage = "نمی توانید بیشتر از ۴ کاراکتر وارد کنید")]
        [MinLength(4, ErrorMessage = "نمی توانید کمتر از ۴ کاراکتر وارد کنید")]
        public string StartDate { get; set; }
        [Display(Name = "تاریخ پایان")]
        [Required(ErrorMessage = "لطفا تاریخ پایان را وارد نمایید")]
        [MaxLength(4, ErrorMessage = "نمی توانید بیشتر از ۴ کاراکتر وارد کنید")]
        [MinLength(4, ErrorMessage = "نمی توانید کمتر از ۴ کاراکتر وارد کنید")]
        public string EndDate { get; set; }
        [Display(Name = "توضیحات")]
        [MaxLength(10000, ErrorMessage = "نمی توانید بیشتر از ۱۰۰۰۰ کاراکتر وارد کنید")]
        public string Description { get; set; }
        [Display(Name = "اولویت")]
        public int Order { get; set; }
    }
}
