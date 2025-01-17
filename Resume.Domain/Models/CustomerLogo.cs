﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Domain.Models
{
    public class CustomerLogo
    {
        [Key]
        public long Id { get; set; }
        [Display(Name = "لوگو")]
        [Required(ErrorMessage = "لطفا{۰} وارد نمایید")]
        public string Logo { get; set; }
        [Display(Name = "توضیحات لوگو")]
        [Required(ErrorMessage = "لطفا{۰} وارد نمایید")]
        public string LogoAlt { get; set; }
        [Display(Name = "لینک")]
        [Required(ErrorMessage = "لطفا{۰} وارد نمایید")]
        public string Link { get; set; }
        [Display(Name = "اولویت")]
        public int Order { get; set; } = 0;
    }
}
