using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume_V2.Domain.Models
{
    public class Blog
    {
        [Key]
        public long Id { get; set; }
        [Display(Name = "تصویر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Image { get; set; }
        [Display(Name = "تصویر")]
        public string? DescriptionImage { get; set; }
        [Display(Name = "تصویر")]
        public string? DescriptionImage2 { get; set; }
        [Display(Name = "تاریخ انتشار")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(100, ErrorMessage = "نمی تواند بیشتر از {1} کاراکتر باشد {0}.")]
        public string Date { get; set; }
        [Display(Name = "توضیحات")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [DataType(DataType.MultilineText)]
        public string DescriptionText { get; set; }
        [Display(Name = "توضیحات")]
        [DataType(DataType.MultilineText)]
        public string? DescriptionText2 { get; set; }
        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(100, ErrorMessage = "نمی تواند بیشتر از {1} کاراکتر باشد {0}.")]
        public string Title { get; set; }
        [Display(Name = "انتشار دهنده")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(100, ErrorMessage = "نمی تواند بیشتر از {1} کاراکتر باشد {0}.")]
        public string Publisher { get; set; }
        [Display(Name = "اولویت")]
        public int Order { get; set; } = 0;
        [Display(Name = "عنوان متن بدنه")]
        [MaxLength(100, ErrorMessage = "نمی تواند بیشتر از {1} کاراکتر باشد {0}.")]
        public string? DescriptionTitle { get; set; }
        [Display(Name = "عنوان متن بدنه")]
        [MaxLength(100, ErrorMessage = "نمی تواند بیشتر از {1} کاراکتر باشد {0}.")]
        public string? DescriptionTitle2 { get; set; }

        public long BlogCategoryId { get; set; }
        [ForeignKey("BlogCategoryId")]
        public virtual BlogCategory BlogCategory { get; set; }
    }
}
