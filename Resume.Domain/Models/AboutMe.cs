using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Domain.Models
{
    public class AboutMe
    {
        [Key]
        public long Id { get; set; }
        [Display(Name = "تایتل")]
        [Required(ErrorMessage = "لطفا{۰} وارد نمایید")]
        [MaxLength(500, ErrorMessage = "{نمیتواند بیشتر از {۱} کاراکتر باشد {0")]
        public string title { get; set; }
        [Display(Name = "پاراگراف-۱")]
        [Required(ErrorMessage = "لطفا{۰} وارد نمایید")]
        [MaxLength(2000, ErrorMessage = "{نمیتواند بیشتر از {۱} کاراکتر باشد {0")]
        public string paragraf1 { get; set; }
        [Display(Name = "پاراگراف-۲")]
        [MaxLength(1000, ErrorMessage = "{نمیتواند بیشتر از {۱} کاراکتر باشد {0")]
        public string paragraf2 { get; set; }
    }
}
