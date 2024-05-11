using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Domain.ViewModels.CustomerFeedback
{
    public class CustomerFeedbackViewModel
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "آواتار")]
        public string Avatar { get; set; }
        [Display(Name = "نام")]
        public string Name { get; set; }
        [Display(Name = "توضیحات")]
        public string Description { get; set; }
        [Display(Name = "اولویت")]
        public int Order { get; set; }
        [Display(Name = "در مورد شغل")]
        public string AboutJob { get; set; }
    }
}
