using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Domain.ViewModels.Skill
{
    public class CreateOrEditSkillViewModel
    {
        public long Id { get; set; }
        [Display(Name = "عنوان")]
        [MaxLength(50, ErrorMessage = "نمی توانید بیشتر از ۵۰ کاراکتر وارد کنید")]
        [Required(ErrorMessage = "لطفا عنوان را وارد کنید")]
        public string Title { get; set; }
        [Display(Name = "درصد")]
        [Required(ErrorMessage = "لطفا درصد وارد نمایید")]
        [MaxLength(100, ErrorMessage = "نمی توانید بیشتر از ۱۰۰ کاراکتر وارد کنید")]
        [MinLength(1, ErrorMessage = "نمی توانید کمتر از ۱ کاراکتر وارد کنید")]
        public string Percent { get; set; }
        [Display(Name = "اولویت")]
        public int Order { get; set; }
    }
}
