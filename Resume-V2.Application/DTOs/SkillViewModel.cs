using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume_V2.Application.DTOs
{
    public class SkillViewModel
    {
        public long Id { get; set; }
        [Display(Name = "نام مهارت")]
        public string AbilityName { get; set; }
        [Display(Name = "آیکون")]
        public string Icon { get; set; }
        [Display(Name = "درصد مهارت")]
        public int Percent { get; set; }
    }
}
