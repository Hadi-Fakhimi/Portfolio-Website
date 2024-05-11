using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Domain.Models
{
    public class Information
    {
        [Key]
        public long Id { get; set; }
        [Display(Name = "آواتار")]
        public string Avatar { get; set; }
        [Display(Name = "نام")]
        [MaxLength(100, ErrorMessage = "{نمیتواند بیشتر از {۱} کاراکتر باشد {0")]
        public string Name { get; set; }
        [Display(Name = "شغل")]
        [MaxLength(100, ErrorMessage = "{نمیتواند بیشتر از {۱} کاراکتر باشد {0")]
        public string Job { get; set; }
        [Display(Name = "تاریخ تولد")]
        [MaxLength(100, ErrorMessage = "{نمیتواند بیشتر از {۱} کاراکتر باشد {0")]
        public string DateOfBirth { get; set; }
        [Display(Name = "آدرس")]
        [MaxLength(1000, ErrorMessage = "{نمیتواند بیشتر از {۱} کاراکتر باشد {0")]
        public string Address { get; set; }
        [Display(Name = "ایمیل")]
        [MaxLength(100, ErrorMessage = "{نمیتواند بیشتر از {۱} کاراکتر باشد {0")]
        public string Email { get; set; }
        [Display(Name = "تلفن")]
        [MaxLength(100, ErrorMessage = "{نمیتواند بیشتر از {۱} کاراکتر باشد {0")]
        public string Phone { get; set; }
        [Display(Name = "فایل رزومه")]
        [MaxLength(100, ErrorMessage = "{نمیتواند بیشتر از {۱} کاراکتر باشد {0")]
        public string ResumeFile { get; set; }
        [Display(Name = "آدرس نقشه")]
        public string MapSrc { get; set; }
        [Display(Name = "آدرس تلگرام")]
        [MaxLength(100, ErrorMessage = "{نمیتواند بیشتر از {۱} کاراکتر باشد {0")]
        public string TelegramAddress { get; set; }
        [Display(Name = "آدرس اینستاگرام")]
        [MaxLength(100, ErrorMessage = "{نمیتواند بیشتر از {۱} کاراکتر باشد {0")]
        public string InstagramAddress { get; set; }


    }
}
