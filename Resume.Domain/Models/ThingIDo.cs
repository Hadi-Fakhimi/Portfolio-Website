using System;
using System.ComponentModel.DataAnnotations;

namespace Resume.Domain.Models
{
    public class ThingIDo
    {
        #region properties
        [Key]
        public long Id { get; set; }
        [Display(Name = "آیکون")]
        [MaxLength(50,ErrorMessage ="{نمیتواند بیشتر از {۱} کاراکتر باشد {0")]
        public string Icon { get; set; }
        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "لطفا{۰} وارد نمایید")]
        [MaxLength(100, ErrorMessage = "{نمیتواند بیشتر از {۱} کاراکتر باشد {0")]
        public string Title { get; set; }
        [Display(Name = "توضیحات")]
        [Required(ErrorMessage = "لطفا{۰} وارد نمایید")]
        [MaxLength(1000, ErrorMessage = "{نمیتواند بیشتر از {۱} کاراکتر باشد {0")]
        public string description { get; set; }
        [Display(Name = "عرض ستون آیتم")]
        [Range(4, 12, ErrorMessage = "مقدار وارد شده باید بین ۴ تا ۱۲ باشد")]
        public int Col_lg { get; set; } = 6;

        [Display(Name = "اولویت")]
        public int Order { get; set; } = 0;

        #endregion
    }
}
