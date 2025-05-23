using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume_V2.Application.DTOs
{
    public class InformationViewModel
    {
        [Display(Name = "نام")]

        public string Name { get; set; }
        [Display(Name = "شغل")]

        public string Job { get; set; }
        [Display(Name = "تاریخ تولد")]

        public string DateOfBirth { get; set; }
        [Display(Name = "آدرس")]

        public string Address { get; set; }
        [Display(Name = "ایمیل")]

        public string Email { get; set; }
        [Display(Name = "تلفن")]

        public string Phone { get; set; }
        [Display(Name = "فایل رزومه")]

        public string ResumeFile { get; set; }
        [Display(Name = "آدرس نقشه")]
        public string MapSrc { get; set; }
        [Display(Name = "آدرس تلگرام")]

        public string TelegramAddress { get; set; }
        [Display(Name = "آدرس اینستاگرام")]

        public string InstagramAddress { get; set; }
    }
}
