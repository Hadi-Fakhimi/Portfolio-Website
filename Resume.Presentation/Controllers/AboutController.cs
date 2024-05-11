using Microsoft.AspNetCore.Mvc;
using Resume.Application.Services.Interfaces;
using Resume.Domain.ViewModels.Page;
using System.Threading.Tasks;

namespace Resume.Presentation.Controllers
{
    public class AboutController : Controller
    {



        #region Constructor
        private readonly IThingIDoService _thingIDoService;
        private readonly ICustomerFeedbackService _customerFeedback;
        private readonly ICustomerLogoService _customerLogo;
        private readonly IAboutMeService _aboutMeService;
        private readonly IItemIDoService _itemIDoService;
        public AboutController(IThingIDoService thingIDoService, ICustomerFeedbackService customerFeedback, ICustomerLogoService customerLogo, IAboutMeService aboutMeService, IItemIDoService itemIDoService)
        {
            _thingIDoService = thingIDoService;
            _customerFeedback = customerFeedback;
            _customerLogo = customerLogo;
            _aboutMeService = aboutMeService;
            _itemIDoService = itemIDoService;
        }

        #endregion
        public async Task<IActionResult> Index()
        {
            
            IndexPageViewModel model = new IndexPageViewModel()
            {

                ThingIDoList = await _thingIDoService.GetAllThingIDoForIndex(),
                CustomerFeedbackList = await _customerFeedback.GetCustomerFeedbackForIndex(),
                CustomerLogoList = await _customerLogo.GetCustomerLogosForIndexPage(),
                AboutMeView = await _aboutMeService.GetAllAboutMeForIndex(),
                ItemIDoList = await _itemIDoService.GetAllItemIDo()

            };
            return View(model);
        }

    }
}
