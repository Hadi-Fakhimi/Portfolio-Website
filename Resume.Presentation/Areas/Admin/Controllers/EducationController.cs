using Microsoft.AspNetCore.Mvc;
using Resume.Application.Services.Interfaces;
using Resume.Domain.ViewModels.Education;
using System.Threading.Tasks;

namespace Resume.Presentation.Areas.Admin.Controllers
{
    public class EducationController : AdminBaseController
    {
        #region Constructor

        private readonly IEducationSerivce _educationService;

        public EducationController(IEducationSerivce educationSerivce)
        {
            _educationService = educationSerivce;
        }


        #endregion
        public async Task<IActionResult> Index()
        {
            return View(await _educationService.GetEducationForIndexPage());
        }

        public async Task<IActionResult> LoadEducationFormModal(long id)
        {
            CreateOrEditEducationViewModel result = await _educationService.FillCreateOrEditEducationViewModel(id);
            return PartialView("_EducationModalPartial", result);
        }

        public async Task<IActionResult> SubmitEducationFormModal(CreateOrEditEducationViewModel education)
        {
            var result = await _educationService.CreateOrEditeEducation(education);
            if (result)
            {
                return new JsonResult(new { status = "Success" });
            }

            return new JsonResult(new { status = "Error" });
        }
        public async Task<IActionResult> DeleteEducation(long id)
        {
            var result = await _educationService.DeleteEducation(id);

            if (result)
            {
                return new JsonResult(new { status = "Success" });
            }

            return new JsonResult(new { status = "Error" });
        }
    }
}
