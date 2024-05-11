using GoogleReCaptcha.V3.Interface;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Resume.Application.Security;
using Resume.Application.Services.Interfaces;
using Resume.Domain.ViewModels.Account;
using Resume.Presentation.ActionFilters;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Resume.Presentation.Controllers
{
    public class AccountController : BaseController
    {
        #region Constructor

        private readonly IUserService _userService;
        private readonly ICaptchaValidator _captchaValidator;

        public AccountController(IUserService userService , ICaptchaValidator captchaValidator)
        {
            _userService = userService;
            _captchaValidator = captchaValidator;
        }

        #endregion

        #region Login
        [HttpGet("Login")]
        [RedirectHomeIfLoggedInActionFilters]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost("Login"), ValidateAntiForgeryToken]
        [RedirectHomeIfLoggedInActionFilters]
        public async Task<IActionResult> Login(LoginViewModel login)
        {
            if (!await _captchaValidator.IsCaptchaPassedAsync(login.Captcha))
            {
                TempData[ErrorMessage] = "اعتبار سنجی captcha با مشکل مواجه شد لطفا دوباره امتحان کنید.";
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
                    TempData[ErrorMessage] = "کاربر مورد نظر یافت نشد";
                    break;
                case LoginResult.EmailNotActivated:
                    TempData[WarningMessage] = "برای ورود به حساب کاربری ابتدا ایمیل خود را فعال کنید";
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
                    TempData[SuccessMessage] = "خوش آمدید";
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
        public async Task<IActionResult> ForgotPassword()
        {
            return View();
        }
        [HttpPost("Forgot-Password"),ValidateAntiForgeryToken]
        [RedirectHomeIfLoggedInActionFilters]
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
            if(user == null || user.IsDelete)
            {
                return NotFound();
            }

            return View(new ResetPasswordViewModel() { EmailActivationCode = user.EmailActivationCode });
        }

        [HttpPost("Reset-Password/{emailActivationCode}"),ValidateAntiForgeryToken]
        [RedirectHomeIfLoggedInActionFilters]
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
