using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Domain.ViewModels.AboutMe
{
    public class AboutMeViewModel
    {
        public long Id { get; set; }
        [Display(Name = "تایتل")]
        public string title { get; set; }
        [Display(Name = "پاراگراف-۱")]
        public string paragraf1 { get; set; }
        [Display(Name = "پاراگراف-۲")]
        public string paragraf2 { get; set; }
    }
}
