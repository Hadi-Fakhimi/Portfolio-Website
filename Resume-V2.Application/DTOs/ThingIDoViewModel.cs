using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume_V2.Application.DTOs
{
    public class ThingIDoViewModel
    {
        public long Id { get; set; }
        [Display(Name = "آیکون")]

        public string Icon { get; set; }
        [Display(Name = "عنوان")]

        public string Title { get; set; }
        [Display(Name = "توضیحات")]

        public string description { get; set; }

        [Display(Name = "اولویت")]
        public int Order { get; set; }
    }
}
