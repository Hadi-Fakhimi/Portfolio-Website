using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume_V2.Domain.Models
{
    public class RecordHomePageVisit
    {

        [Key]
        public int Id { get; set; }
        [Display(Name = "تاریخ بازدید")]
        public DateTime Date { get; set; }
        [Display(Name = "تعداد بازدید")]
        public int VisitCount { get; set; }


    }
}
