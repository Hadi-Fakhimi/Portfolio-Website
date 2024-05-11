using Microsoft.AspNetCore.Mvc;
using Resume.Application.Services.Interfaces;
using Resume.Domain.ViewModels.Page;
using System.Threading.Tasks;

namespace Resume.Presentation.Controllers
{
    public class ResumeController : Controller
    {
        #region Cunstractor
        private readonly IEducationSerivce  _educationSerivce;
        private readonly IExperienceService _experienceService;
        private readonly ISkillService _skillService;
        public ResumeController(IEducationSerivce educationSerivce, IExperienceService experienceService, ISkillService skillService)
        {
            _educationSerivce = educationSerivce;
            _experienceService = experienceService;
            _skillService = skillService;
        }
        #endregion
        public async Task<IActionResult> Index()
        {
            ResumePageViewModel model = new ResumePageViewModel()
            {
                Education = await _educationSerivce.GetEducationForIndexPage(),
                Experience = await _experienceService.GetExperienceForIndexPage(),
                Skill = await _skillService.GetSkillForIndexPage()
            };
            return View(model);
        }
    }
}
