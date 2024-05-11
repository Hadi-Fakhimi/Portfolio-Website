using Resume.Domain.ViewModels.SocialMedia;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Domain.ViewModels.CustomerLogo
{
    public class CreateOrEditCustomerLogoListViewModel
    {
        public long Id { get; set; }
        [Display(Name = "لوگو")]
        [Required(ErrorMessage = "لطفا لوگو وارد نمایید")]
        public string Logo { get; set; }
        [Display(Name = "توضیحات لوگو")]
        [Required(ErrorMessage = "لطفا توضیحات لوگو وارد نمایید")]
        public string LogoAlt { get; set; }
        [Display(Name = "لینک")]
        [Required(ErrorMessage = "لطفا لینک وارد نمایید")]
        public string Link { get; set; }
        [Display(Name = "اولویت")]
        public int Order { get; set; }
    }
}
