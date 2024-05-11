using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Domain.ViewModels.AboutMe
{
    public class CreateOrEditAboutMeViewModel
    {
        public long Id { get; set; }
        [Display(Name = "تایتل")]
        [Required(ErrorMessage = "لطفا تایتل وارد نمایید")]
        [MaxLength(500, ErrorMessage = "نمی توانید بیشتر از ۵۰۰ کاراکتر را وارد کنید")]
        public string title { get; set; }
        [Display(Name = "پاراگراف-۱")]
        [Required(ErrorMessage = "لطفا پاراگراف-۱ وارد نمایید")]
        [MaxLength(2000, ErrorMessage = "نمی توانید بیشتر از ۲۰۰۰ کاراکتر را وارد کنید")]
        public string paragraf1 { get; set; }
        [Display(Name = "پاراگراف-۲")]
        [MaxLength(1000, ErrorMessage = "نمی توانید بیشتر از ۱۰۰۰ کاراکتر را وارد کنید")]
        public string paragraf2 { get; set; }
    }
}
