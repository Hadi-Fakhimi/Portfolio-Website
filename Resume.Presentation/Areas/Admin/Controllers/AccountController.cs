using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Resume.Application.Extensions;
using Resume.Application.Generator;
using Resume.Application.Services.Interfaces;
using Resume.Application.StaticTools;
using Resume.Domain.ViewModels.Account;
using System.IO;
using System.Threading.Tasks;

namespace Resume.Presentation.Areas.Admin.Controllers
{
    public class AccountController : AdminBaseController
	{
		#region Constructor

		private readonly IUserService _userService;
        public AccountController(IUserService userService)
        {
            _userService = userService;
        }

        #endregion

        #region UserAdmin
        public async Task<IActionResult> Index()
        {
            return View(await _userService.UserForIndex());
        }

        public async Task<IActionResult> LoadUserAdminFormModal(long id)
        {
            var result = await _userService.FillCreateOrEditUserAdminViewModel(id);
            return PartialView("_UserAdminModalPartial", result);
        }

        public async Task<IActionResult> SubmitUserAdminFormModal(CreateOrEditUserAdminViewModel user)
        {
            var result = await _userService.CreateOrEditUserAdmin(user);

            if (result)
            {
                return new JsonResult(new { status = "Success" });
            }
            return new JsonResult(new { status = "Error" });
        }

        public async Task<IActionResult> DeleteUserAdmin(long id)
        {
            var result = await _userService.DeleteUserAdmin(id);

            if (result)
            {
                return new JsonResult(new { status = "Success" });
            }
            return new JsonResult(new { status = "Error" });
        }

        [HttpPost]
        public async Task<IActionResult> UploadUserAdminAjaxImage(IFormFile file)
        {
            if (file != null)
            {
                if (Path.GetExtension(file.FileName) == ".png" || Path.GetExtension(file.FileName) == ".svg" || Path.GetExtension(file.FileName) == ".jpg")
                {
                    var imageName = CodeGenerator.GenerateUniqCode() + Path.GetExtension(file.FileName);
                    await file.AddImageAjaxToServer(imageName, FilePaths.UserAvatarImgServer);

                    return new JsonResult(new { status = "Success", imageName = imageName });
                }
                else
                {
                    return new JsonResult(new { status = "Error" });
                }

            }
            else
            {
                return new JsonResult(new { status = "Error" });
            }
        }

        #endregion

        #region Email Activatio Code
        [HttpGet("Activate-Email/{activationCode}")]
        public async Task<IActionResult> ActivationUserEmail(string activationCode)
        {
            var result = await _userService.ActivateUserEmail(activationCode);
            if (result)
            {
                TempData[SuccessMessage] = "حساب کاربری با موفقیت فعال شد";
                
            }
            else
            {
                TempData[ErrorMessage] = "فعال سازی حساب کاربری با خطا مواجه شد";
            }

            return RedirectToAction("Login");

        }

        #endregion
    }
}
