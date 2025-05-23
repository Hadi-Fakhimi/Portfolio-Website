using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume_V2.Domain.Models
{
    public class CustomerFeedback
    {
        public int Id { get; set; }
        [Display(Name = "آواتار")]
        public string Avatar { get; set; }
        [Display(Name = "نام")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(100, ErrorMessage = "نمی تواند بیشتر از {1} کاراکتر باشد {0}.")]
        public string Name { get; set; }
        [Display(Name = "توضیحات")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [Display(Name = "اولویت")]
        public int Order { get; set; } = 0;
        [Display(Name = "در مورد شغل")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(100, ErrorMessage = "نمی تواند بیشتر از {1} کاراکتر باشد {0}.")]
        public string AboutJob { get; set; }
        [Display(Name = "امتیاز")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(4, ErrorMessage = "نمی تواند بیشتر از {1} کاراکتر باشد {0}.")]
        public long FeedbackScore { get; set; }

    }

}
