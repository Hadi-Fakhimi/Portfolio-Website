using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume_V2.Application.DTOs
{
    public class CreateOrEditAboutMeViewModel
    {
        public long Id { get; set; }
        [Display(Name = "عنوان شاخه کاری")]
        public string Title { get; set; }
        [Display(Name = "نام و نام خانوادگی")]
        public string Name { get; set; }
        [Display(Name = "توضیحات")]
        public string Description { get; set; }
        [Display(Name = "آواتار")]
        public string AvatarImage { get; set; }
    }
}
