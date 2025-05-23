using GoogleReCaptcha.V3.Interface;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Resume_V2.Application.DTOs;
using Resume_V2.Application.Services.Interfaces;
using System.Security.Claims;
using Resume_V2.Presenation.ActionFilters;
using Resume_V2.Application.Security;

namespace Resume_V2.Presenation.Controllers
{
    public class AccountController : BaseController
    {
        #region Construcntor
        private readonly ICaptchaValidator _captchaValidator;
        private readonly IUser _userService;
        public AccountController(ICaptchaValidator captchaValidator, IUser userService)
        {
            _captchaValidator = captchaValidator;
            _userService = userService;
        }
        #endregion
        #region Login
        [HttpGet("Login")]
        [RedirectHomeIfLogedInActionFilters]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost("Login"), ValidateAntiForgeryToken]
        [RedirectHomeIfLogedInActionFilters]
        public async Task<IActionResult> Login(LoginViewModel login)
        {
            if (!await _captchaValidator.IsCaptchaPassedAsync(login.Captcha))
            {
                TempData[ErrorMessage] = "اعتبار سنجی Captcha با مشکل مواجه شد";
                return View(login);
            }
            if (!ModelState.IsValid)
            {

                return View(login);
            }

            var result = await _userService.CheckUserForLogin(login);
            switch (result)
            {
                case LoginResult.UserNotFound:
                    TempData[ErrorMessage] = "نام کاربری یا کلمه عبور اشتباه است";
                    break;
                case LoginResult.EmailNotActivated:
                    TempData[WarningMessage] = "حساب خود را فعال کنید";
                    break;
                case LoginResult.Success:
                    var user = await _userService.GetUserByEmail(login.Email);

                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.NameIdentifier,user.Id.ToString())
                    };
                    var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var principal = new ClaimsPrincipal(identity);
                    var properties = new AuthenticationProperties { IsPersistent = login.RememberMe };

                    await HttpContext.SignInAsync(principal, properties);
                    TempData[SuccessMessage] = "ورود با موفقیت , خوش آمدید";
                    return Redirect("/");
            }
            return View(login);
        }
        #endregion
        #region Logout
        [HttpGet("Logout")]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/");
        }
        #endregion
        #region Forgot Password
        [HttpGet("Forgot-Password")]
        [RedirectHomeIfLogedInActionFilters]
        public async Task<IActionResult> ForgotPassword()
        {
            return View();
        }
        [HttpPost("Forgot-Password"), ValidateAntiForgeryToken]
        [RedirectHomeIfLogedInActionFilters]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordViewModel forgot)
        {
            if (!await _captchaValidator.IsCaptchaPassedAsync(forgot.Captcha))
            {
                TempData[ErrorMessage] = "اعتبار سنجی captcha با مشکل مواجه شد لطفا دوباره امتحان کنید.";
                return View(forgot);
            }
            if (!ModelState.IsValid)
            {
                return View(forgot);
            }

            var result = await _userService.ForgotPassword(forgot);

            switch (result)
            {
                case ForgotPasswordResualt.UserNotFound:
                    TempData[ErrorMessage] = "کاربری با مشخصات مورد نظر یافت نشد";
                    break;
                case ForgotPasswordResualt.Success:
                    TempData[InfoMessage] = "لینک باریابی رمز عبور به ایمیل شما ارسال شد";
                    return RedirectToAction("Login");


            }
            return View(forgot);
            

        }

		#endregion
		#region Reset Password
		[HttpGet("Reset-Password/{emailActivationCode}")]
		public async Task<IActionResult> ResetPassword(string emailActivationCode)
		{
			var user = await _userService.GetUserByActivationCode(emailActivationCode.SanitizeText());
			if (user == null || user.IsDelete)
			{
				return NotFound();
			}

			return View(new ResetPasswordViewModel() { EmailActivationCode = user.EmailActivationCode });
		}

		[HttpPost("Reset-Password/{emailActivationCode}"), ValidateAntiForgeryToken]
		[RedirectHomeIfLogedInActionFilters]
		public async Task<IActionResult> ResetPassword(ResetPasswordViewModel reset)
		{
			if (!await _captchaValidator.IsCaptchaPassedAsync(reset.Captcha))
			{
				TempData[ErrorMessage] = "اعتبار سنجی captcha با مشکل مواجه شد لطفا دوباره امتحان کنید.";
				return View(reset);
			}
			if (!ModelState.IsValid)
			{
				return View(reset);
			}

			var result = await _userService.ResetPassword(reset);

			switch (result)
			{
				case ResetPasswordResult.UserNotFound:
					TempData[ErrorMessage] = "کاربری با مشخصات مورد نظر یافت نشد";
					break;
				case ResetPasswordResult.Success:
					TempData[SuccessMessage] = "کلمه عبور شما با موفقیت بازیابی شد";
					return RedirectToAction("Login");


			}
			return View(reset);
		}
		#endregion
	}
}
