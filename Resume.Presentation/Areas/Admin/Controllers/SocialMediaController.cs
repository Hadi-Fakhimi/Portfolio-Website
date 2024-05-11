using Microsoft.AspNetCore.Mvc;
using Resume.Application.Services.Interfaces;
using Resume.Domain.ViewModels.SocialMedia;
using System.Threading.Tasks;

namespace Resume.Presentation.Areas.Admin.Controllers
{
    public class SocialMediaController : AdminBaseController
    {
        private readonly ISocialMediaService _socialMediaService;
        public SocialMediaController(ISocialMediaService socialMediaService)
        {
            _socialMediaService = socialMediaService;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _socialMediaService.GetAllSocialMedias());
        }

        public async Task<IActionResult> LoadSocialMediaFormModal(long id)
        {
            var result = await _socialMediaService.FillCreateOrEditSocialMediaViewModel(id);
            return PartialView("_SocialMediaModalPartial", result);
        }

        public async Task<IActionResult> SubmitSocialMediaFormModal(CreateOrEditSocialMediaViewModel socialMedia)
        {
            var result = await _socialMediaService.CreateOrEditeSocialMedia(socialMedia);

            if (result)
            {
                return new JsonResult(new { status = "Success" });
            }
            return new JsonResult(new { status = "Error" });

        }

        public async Task<IActionResult> DeleteSocialMedia(long id)
        {
            var result = await _socialMediaService.DeleteSocialMedia(id);

            if (result)
            {
                return new JsonResult(new { status = "Success" });
            }
            return new JsonResult(new { status = "Error" });
        }
    }
}

