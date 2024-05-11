using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Domain.Models
{
    public class Education
    {
        [Key]
        public long Id { get; set; }
        [Display(Name = "عنوان")]
        [MaxLength(50,ErrorMessage ="{نمیتواند بیشتر از {۱} کاراکتر باشد {0")]
        [Required(ErrorMessage = "لطفا{۰} وارد نمایید")]
        public string Title { get; set; }
        [Display(Name = "تاریخ شروع")]
        [Required(ErrorMessage = "لطفا{۰} وارد نمایید")]
        [MaxLength(4, ErrorMessage = "{نمیتواند بیشتر از {۱} کاراکتر باشد {0")]
        [MinLength(4, ErrorMessage = "{نمیتواند کمتر از {۱} کاراکتر باشد {0")]
        public string StartDate { get; set; }
        [Display(Name = "تاریخ پایان")]
        [Required(ErrorMessage = "لطفا{۰} وارد نمایید")]
        [MaxLength(4, ErrorMessage = "{نمیتواند بیشتر از {۱} کاراکتر باشد {0")]
        [MinLength(4, ErrorMessage = "{نمیتواند کمتر از {۱} کاراکتر باشد {0")]
        public string EndDate { get; set; }
        [Display(Name = "توضیحات")]
        [MaxLength(10000, ErrorMessage = "{نمیتواند بیشتر از {۱} کاراکتر باشد {0")]
        public string Description { get; set; }
        [Display(Name = "اولویت")]
        public int Order { get; set; } = 0;
    }
}
