using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Domain.Models
{
    public class CustomerFeedback
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "آواتار")]
        public string Avatar { get; set; }
        [Display(Name = "نام")]
        [Required(ErrorMessage = "لطفا{۰} وارد نمایید")]
        [MaxLength(100,ErrorMessage ="{نمیتواند بیشتر از {۱} کاراکتر باشد {0")]
        public string Name { get; set; }
        [Display(Name = "توضیحات")]
        [Required(ErrorMessage = "لطفا{۰} وارد نمایید")]
        [MaxLength(100, ErrorMessage = "{نمیتواند بیشتر از {۱} کاراکتر باشد {0")]
        public string Description { get; set; }
        [Display(Name = "اولویت")]
        public int Order { get; set; } = 0;
        [Display(Name = "در مورد شغل")]
        [Required(ErrorMessage = "لطفا{۰} وارد نمایید")]
        [MaxLength(100, ErrorMessage = "{نمیتواند بیشتر از {۱} کاراکتر باشد {0")]
        public string AboutJob { get; set; }


    }
}
