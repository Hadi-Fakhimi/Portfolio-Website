using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Domain.ViewModels.ItemIDo
{
    public class CreateOrEditItemIDoViewModel
    {
        public long Id { get; set; }
        [Display(Name = "نام")]
        [Required(ErrorMessage = "لطفا نام وارد نمایید")]
        [MaxLength(100, ErrorMessage = "نمی توانید بیشتر از ۱۰۰ کاراکتر را وارد کنید")]
        public string Name { get; set; }
        [Display(Name = "تعداد")]
        [Required(ErrorMessage = "لطفا تعداد وارد نمایید")]
        [MaxLength(100, ErrorMessage = "نمی توانید بیشتر از ۱۰۰ کاراکتر را وارد کنید")]
        public string Number { get; set; }
        [Display(Name = "اولویت")]
        public int Order { get; set; }
    }
}
