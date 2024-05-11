using Microsoft.AspNetCore.Mvc;
using Resume.Application.Services.Interfaces;
using Resume.Domain.ViewModels.Experience;
using System.Threading.Tasks;

namespace Resume.Presentation.Areas.Admin.Controllers
{
    public class ExperienceController : AdminBaseController
    {
        #region Constructor
        private readonly IExperienceService _experienceService;

        public ExperienceController(IExperienceService experienceService)
        {
            _experienceService = experienceService;
        }

        #endregion
        public async Task<IActionResult> Index()
        {
            return View(await _experienceService.GetExperienceForIndexPage() );
        }

        public async Task<IActionResult> LoadExperienceFormModal(long id)
        {
            CreateOrEditExperienceViewModel result = await _experienceService.FillCreateOrEditExperienceViewModel(id);

            return PartialView("_ExperienceModalPartial", result);
        }
        public async Task<IActionResult> SubmitExperienceFormModal(CreateOrEditExperienceViewModel experience)
        {
            var result = await _experienceService.CreateOrEditExperience(experience);

            if (result)
            {
                return new JsonResult(new { status = "Success" });
            }

            return new JsonResult(new { status = "Error" });
        }
        public async Task<IActionResult> DeleteExperience(long id)
        {
            var result = await _experienceService.DeleteExperience(id);

            if (result)
            {
                return new JsonResult(new { status = "Success" });
            }

            return new JsonResult(new { status = "Error" });
        }
        

        
    }
}
