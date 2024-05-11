using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Domain.ViewModels.SocialMedia
{
    public class CreateOrEditSocialMediaViewModel
    {
        public long Id { get; set; }
        [Display(Name = "آیکون")]
        [MaxLength(100, ErrorMessage = "نمی تواند بیشتر از ۱۰۰ کاراکتر باشد")]
        public string Icon { get; set; }
        [Display(Name = "لینک")]
        [Required(ErrorMessage = "لطفا لینک وارد نمایید")]
        [MaxLength(1000, ErrorMessage = "نمی تواند بیشتر از ۱۰۰۰ کاراکتر باشد")]
        public string Link { get; set; }
        [Display(Name = "اولویت")]
        public int Order { get; set; }
    }
}
