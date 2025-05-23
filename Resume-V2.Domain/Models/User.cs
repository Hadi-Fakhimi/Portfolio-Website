using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume_V2.Domain.Models
{
    public class User
    {

        #region Properties
        [Key]
        public long Id { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public bool IsDelete { get; set; } = false;
        [Display(Name = "نام")]
        [MaxLength(100, ErrorMessage = "نمی تواند بیشتر از {1} کاراکتر باشد {0}.")]
        public string FirstName { get; set; }
        [Display(Name = "نام خانوادگی")]
        [MaxLength(100, ErrorMessage = "نمی تواند بیشتر از {1} کاراکتر باشد {0}.")]
        public string LastName { get; set; }
        [Display(Name = "ایمیل")]
        [MaxLength(100, ErrorMessage = "نمی تواند بیشتر از {1} کاراکتر باشد {0}.")]
        [EmailAddress(ErrorMessage = "ایمیل وارد شده معتبر نمی باشد")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Email { get; set; }
        [Display(Name = "پسورد")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Password { get; set; }
        [Display(Name = "توضیحات")]
        public string Description { get; set; }
        [Display(Name = "ایمیل")]
        public bool IsEmailConfirmed { get; set; }
        public string EmailActivationCode { get; set; }
        public string Avatar { get; set; }



        #endregion
    }
}
