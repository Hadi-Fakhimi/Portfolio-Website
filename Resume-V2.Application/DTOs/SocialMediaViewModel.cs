using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume_V2.Application.DTOs
{
    public class SocialMediaViewModel
    {
        public long Id { get; set; }
        [Display(Name = "آیکون")]

        public string Icon { get; set; }
        [Display(Name = "لینک")]

        public string Link { get; set; }
        [Display(Name = "اولویت")]
        public int Order { get; set; }
    }
}
