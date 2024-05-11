using Microsoft.AspNetCore.Mvc;
using Resume.Application.Services.Interfaces;
using Resume.Domain.ViewModels.AboutMe;
using Resume.Presentation.ActionFilters;
using System.Threading.Tasks;

namespace Resume.Presentation.Areas.Admin.Controllers
{
    public class AboutMeController : AdminBaseController
    {
        #region Constructor

        private readonly IAboutMeService _aboutMeService;
        public AboutMeController(IAboutMeService aboutMeService)
        {
            _aboutMeService = aboutMeService;
        }

        #endregion
        public async Task<IActionResult> Index()
        {
            return View(await _aboutMeService.GetAllAboutMeForIndex());
        }

        public async Task<IActionResult> LoadAboutMeFormModal(long id)
        {
            var result = await _aboutMeService.FillCreateOrEditAboutMeViewModel(id);
            return PartialView("_AboutMeModalPartial",result);
        }

        public async Task<IActionResult> SubmitAboutMeFormModal(CreateOrEditAboutMeViewModel aboutMe)
        {
            var result = await _aboutMeService.CreateOrEditAboutMe(aboutMe);

            if (result)
            {
                return new JsonResult(new { status = "Success" });
            }
            return new JsonResult(new { status = "Error" });

        }

        public async Task<IActionResult> DeleteAboutMe(long id)
        {
            var result = await _aboutMeService.DeleteAboutMe(id);

            if (result)
            {
                return new JsonResult(new { status = "Success" });
            }
            return new JsonResult(new {status = "Error"});
        }
    }
}
