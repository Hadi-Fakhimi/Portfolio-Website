using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Domain.ViewModels.PortfolioCategory
{
    public class PortfolioCategoryViewModel
    {
        [Key]
        public long Id { get; set; }
        [Display(Name = "عنوان")]
        public string Title { get; set; }
        [Display(Name = "نام")]
        public string Name { get; set; }
        [Display(Name = "اولویت")]
        public int Order { get; set; } = 0;

    }
}
