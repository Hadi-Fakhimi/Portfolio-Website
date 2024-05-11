using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Domain.Models
{
    public class Skill
    {
        [Key]
        public long Id { get; set; }
        [Display(Name = "عنوان")]
        [MaxLength(50, ErrorMessage = "{نمیتواند بیشتر از {۱} کاراکتر باشد {0")]
        [Required(ErrorMessage = "لطفا{۰} وارد نمایید")]
        public string Title { get; set; }
        [Display(Name = "درصد")]
        [Required(ErrorMessage = "لطفا{۰} وارد نمایید")]
        [MaxLength(100, ErrorMessage = "{نمیتواند بیشتر از {۱} کاراکتر باشد {0")]
        [MinLength(1, ErrorMessage = "{نمیتواند کمتر از {۱} کاراکتر باشد {0")]
        public string Percent { get; set; }
        [Display(Name = "اولویت")]
        public int Order { get; set; } = 0;
        

    }
}
