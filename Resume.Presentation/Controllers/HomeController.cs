using Microsoft.AspNetCore.Mvc;
using Resume.Application.Services.Interfaces;
using Resume.Domain.ViewModels.Page;
using Resume.Domain.ViewModels.SocialMedia;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Resume.Presentation.Controllers
{
    public class HomeController : Controller
    {
        #region Constructor

        private readonly ISocialMediaService _socialMediaService;
        private readonly IInformationService _informationService;

        public HomeController(ISocialMediaService socialMediaService, IInformationService informationService)
        {
            _socialMediaService = socialMediaService;
            _informationService = informationService;
        }

        #endregion
        public async Task<IActionResult> Index()
        {
            HomePageViewModel model = new HomePageViewModel()
            {
                SocialMediaList = await _socialMediaService.GetAllSocialMedias(),
                informationView = await _informationService.GetInformation()
            };
            return View(model);
        }

    }
}
