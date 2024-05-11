using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Domain.Models
{
    public class ItemIDo
    {
        [Key]
        public long Id { get; set; }
        [Display(Name = "نام")]
        [Required(ErrorMessage = "لطفا{۰} وارد نمایید")]
        [MaxLength(100, ErrorMessage = "{نمیتواند بیشتر از {۱} کاراکتر باشد {0")]
        public string Name { get; set; }
        [Display(Name = "تعداد")]
        [Required(ErrorMessage = "لطفا{۰} وارد نمایید")]
        [MaxLength(100, ErrorMessage = "{نمیتواند بیشتر از {۱} کاراکتر باشد {0")]
        public string Number { get; set; }
        [Display(Name = "اولویت")]
        public int Order { get; set; }
    }
}
