using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Domain.ViewModels.Account
{
	public class UserViewModel
    {
        public long Id { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        [Display(Name = "ایمیل")]
		[MaxLength(100, ErrorMessage = "نمی تواند بیشتر از ۱۰۰ کاراکتر باشد")]
		[EmailAddress(ErrorMessage = "ایمیل وارد شده معتبر نمی باشد")]
		[Required(ErrorMessage = "لطفا ایمیل را وارد کنید")]
		public string Email { get; set; }
		[Display(Name = "پسورد")]
		[Required(ErrorMessage = "لطفا پسورد را وارد کنید")]
		[MaxLength(100, ErrorMessage = "نمی تواند بیشتر از ۱۰۰ کاراکتر باشد")]
		public string Password { get; set; }
        public bool IsDelete { get; set; } = false;
        [Display(Name = "نام")]
        [MaxLength(100, ErrorMessage = "نمی تواند بیشتر از ۱۰۰ کاراکتر باشد")]
        public string FirstName { get; set; }
        [Display(Name = "نام خانوادگی")]
        [MaxLength(100, ErrorMessage = "نمی تواند بیشتر از ۱۰۰ کاراکتر باشد")]
        public string LastName { get; set; }
        [Display(Name = "شماره تلفن")]
        [MaxLength(100, ErrorMessage = "نمی تواند بیشتر از ۱۰۰ کاراکتر باشد")]
        public string PhoneNumber { get; set; }
        [Display(Name = "توضیحات")]
        public string Description { get; set; }
        [Display(Name = "ایمیل")]
        public bool IsEmailConfirmed { get; set; }
        public bool IsAdmin { get; set; }
        public string EmailActivationCode { get; set; }
        public string Avatar { get; set; }

    }
}
