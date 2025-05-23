using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume_V2.Domain.Models
{
    public class Item
    {
        [Key]
        public long Id { get; set; }
        [Display(Name = "نام آیتم")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(100, ErrorMessage = "نمی تواند بیشتر از {1} کاراکتر باشد {0}.")]
        public string ItemName { get; set; }
        [Display(Name = "مقدار آیتم")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(20, ErrorMessage = "نمی تواند بیشتر از {1} کاراکتر باشد {0}.")]
        public string Count { get; set; }

    }
}
