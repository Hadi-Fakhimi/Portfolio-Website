using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume_V2.Domain.Models
{
    public class Experience
    {
        [Key]
        public long Id { get; set; }
        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(50, ErrorMessage = "نمی تواند بیشتر از {1} کاراکتر باشد {0}.")]
        public string Title { get; set; }
        [Display(Name = "تاریخ شروع")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(4, ErrorMessage = "نمی تواند بیشتر از {1} کاراکتر باشد {0}.")]
        [MinLength(4, ErrorMessage = "نمی تواند کمتر از {1} کاراکتر باشد {0}.")]
        public string StartDate { get; set; }
        [Display(Name = "تاریخ پایان")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(4, ErrorMessage = "نمی تواند بیشتر از {1} کاراکتر باشد {0}.")]
        [MinLength(4, ErrorMessage = "نمی تواند کمتر از {1} کاراکتر باشد {0}.")]
        public string EndDate { get; set; }
        [Display(Name = "توضیحات")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [Display(Name = "اولویت")]
        public int Order { get; set; } = 0;
    }
}
