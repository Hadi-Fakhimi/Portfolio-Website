using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Domain.ViewModels.ThingIDo
{
    public class CreateOrEditThingIDoViewModel
    {
        public long Id { get; set; }
        [Display(Name = "آیکون")]
        [MaxLength(50, ErrorMessage = "نمی تواند بیشتر از ۵۰ کاراکتر باشد")]
        public string Icon { get; set; }
        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "لطفا عنوان را وارد کنید")]
        [MaxLength(100, ErrorMessage = "نمی تواند بیشتر از ۱۰۰ کاراکتر باشد")]
        public string Title { get; set; }
        [Display(Name = "توضیحات")]
        [Required(ErrorMessage = "لطفا توضیحات را وارد کنید")]
        [MaxLength(1000, ErrorMessage = "نمی تواند بیشتر از ۱۰۰۰ کاراکتر باشد")]
        public string description { get; set; }
        [Display(Name = "عرض ستون آیتم")]
        [Range(4, 12, ErrorMessage = "مقدار وارد شده باید بین ۴ تا ۱۲ باشد")]
        public int Col_lg { get; set; }

        [Display(Name = "اولویت")]
        public int Order { get; set; }
    }
}
