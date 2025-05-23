using Resume_V2.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume_V2.Application.DTOs
{
	public class ResetPasswordViewModel:GoogleRecaptchaViewModel
	{
		[Required(ErrorMessage = "لطفا کد فعالساز را وارد کنید")]
		public string EmailActivationCode { get; set; }

		[Display(Name = "کلمه عبور")]
		[MaxLength(100, ErrorMessage = "نمی تواند بیشتر از {1} کاراکتر باشد {0}.")]
		[Required(ErrorMessage = "لطفا {0} را وارد کنید")]
		public string Password { get; set; }

		[Display(Name = "تکرارکلمه عبور")]
		[MaxLength(100, ErrorMessage = "نمی تواند بیشتر از {1} کاراکتر باشد {0}.")]
		[Required(ErrorMessage = "لطفا {0} را وارد کنید")]
		[Compare("Password", ErrorMessage = "تکرار کلمه عبور با کلمه عبور مغایرت دارد")]
		public string RePassword { get; set; }
	}

	public enum ResetPasswordResult
	{
		Success,
		UserNotFound
	}

}
