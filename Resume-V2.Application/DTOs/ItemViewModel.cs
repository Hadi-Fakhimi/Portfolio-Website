using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume_V2.Application.DTOs
{
    public class ItemViewModel
    {
        public long Id { get; set; }
        [Display(Name = "نام آیتم")]
        public string ItemName { get; set; }
        [Display(Name = "مقدار آیتم")]
        public string Count { get; set; }
    }
}
