using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Resume.Domain.Models
{
    public class PortfolioCategory
    {
        [Key]
        public long Id { get; set; }
        [Display(Name = "عنوان")]
        [MaxLength(100, ErrorMessage = "{نمیتواند بیشتر از {۱} کاراکتر باشد {0")]
        [Required(ErrorMessage = "لطفا{۰} وارد نمایید")]
        public string Title { get; set; }
        [Display(Name = "نام")]
        [MaxLength(100, ErrorMessage = "{نمیتواند بیشتر از {۱} کاراکتر باشد {0")]
        [Required(ErrorMessage = "لطفا{۰} وارد نمایید")]
        public string Name { get; set; }
        [Display(Name = "اولویت")]
        public int Order { get; set; } = 0;


        public ICollection<Portfolio> Portfolios { get; set; }
    }
}
