using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume_V2.Domain.Models
{
    public class PageVisit
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "آدرس صفحه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string PageUrl { get; set; }
        [Display(Name = "تعداد بازدید")]
        public int VisitCount { get; set; }
        [Display(Name = "تاریخ بازدید")]
        public DateTime VisitDate { get; set; }


    }
}
