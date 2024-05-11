using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Domain.Models
{
    public class SocialMedia
    {
        [Key]
        public long Id { get; set; }
        [Display(Name = "آیکون")]
        [MaxLength(100, ErrorMessage = "{نمیتواند بیشتر از {۱} کاراکتر باشد {0")]
        public string Icon { get; set; }
        [Display(Name = "لینک")]
        [Required(ErrorMessage = "لطفا{۰} وارد نمایید")]
        [MaxLength(1000, ErrorMessage = "{نمیتواند بیشتر از {۱} کاراکتر باشد {0")]
        public string Link { get; set; }
        [Display(Name = "اولویت")]
        public int Order { get; set; } = 0;
    }
}
