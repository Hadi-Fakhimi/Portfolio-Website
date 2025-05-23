using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume_V2.Application.DTOs
{
    public class BlogPageViewModel
    {
        public long Id { get; set; }
        [Display(Name = "تصویر")]
        public string Image { get; set; }
        [Display(Name = "تصویر")]
        public string? DescriptionImage { get; set; }
        [Display(Name = "تصویر")]
        public string? DescriptionImage2 { get; set; }
        [Display(Name = "تاریخ انتشار")]
        public string Date { get; set; }
        [Display(Name = "توضیحات")]
        public string DescriptionText { get; set; }
        [Display(Name = "توضیحات")]
        public string? DescriptionText2 { get; set; }
        [Display(Name = "عنوان")]
        public string Title { get; set; }
        [Display(Name = "انتشار دهنده")]
        public string Publisher { get; set; }
        [Display(Name = "عنوان متن بدنه")]
        public string? DescriptionTitle { get; set; }
        [Display(Name = "عنوان متن بدنه")]
        public string? DescriptionTitle2 { get; set; }

        [Display(Name = "نام دسته بندی")]
        public string CategoryName { get; set; }
    }
}
