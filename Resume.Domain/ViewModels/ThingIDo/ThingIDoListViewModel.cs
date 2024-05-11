using System.ComponentModel.DataAnnotations;

namespace Resume.Domain.ViewModels.ThingIDo
{
    public class ThingIDoListViewModel
    {
        #region View Model
        [Key]
        public long Id { get; set; }
        [Display(Name = "آیکون")]
        public string Icon { get; set; }
        [Display(Name = "عنوان")]
        public string Title { get; set; }
        [Display(Name = "توضیحات")]
        public string description { get; set; }
        [Display(Name = "عرض ستون آیتم")]
        public int Col_lg { get; set; }
        [Display(Name = "اولویت")]
        public int Order { get; set; }

        #endregion
    }
}
