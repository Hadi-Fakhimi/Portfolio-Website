using GoogleReCaptcha.V3.Interface;
using Microsoft.AspNetCore.Mvc;
using Resume_V2.Application.DTOs;
using Resume_V2.Application.Services.Impelementations;
using Resume_V2.Application.Services.Interfaces;

namespace Resume_V2.Presenation.Controllers
{
    public class HomeController : BaseController
    {
        #region Constructor

        private readonly ISkill _skillServic;
        private readonly IItem _itemServic;
        private readonly IAboutMe _aboutMeServic;
        private readonly IPortfolio _portfolioServic;
        private readonly IPortfolioCategory _portfolioCategoryServic;
        private readonly IThingIDo _thingIDoServic;
        private readonly ICustomerFeedback _customerFeedbackServic;
        private readonly ICustomerLogo _customerLogoServic;
        private readonly IExperience _experienceServic;
        private readonly IEducation _educationServic;
        private readonly IBlog _blogService;
        private readonly IMessage _messageService;
        private readonly IInformation _informationService;
        private readonly IPageVisit _pageVisitService;
        private readonly ICaptchaValidator _captchaValidator;

        public HomeController(ISkill skillServic, IItem itemServic, IAboutMe aboutMeServic, IPortfolio portfolioServic, IPortfolioCategory portfolioCategoryServic, IThingIDo thingIDoServic, ICustomerFeedback customerFeedbackServic, ICustomerLogo customerLogoServic,
            IExperience experienceServic, IEducation educationServic, IMessage messageService, ICaptchaValidator captchaValidator, IInformation informationService, IBlog blogService, IPageVisit pageVisitService)
        {
            _aboutMeServic = aboutMeServic;
            _skillServic = skillServic;
            _itemServic = itemServic;
            _portfolioServic = portfolioServic;
            _portfolioCategoryServic = portfolioCategoryServic;
            _thingIDoServic = thingIDoServic;
            _customerFeedbackServic = customerFeedbackServic;
            _customerLogoServic = customerLogoServic;
            _educationServic = educationServic;
            _experienceServic = experienceServic;
            _messageService = messageService;
            _captchaValidator = captchaValidator;
            _informationService = informationService;
            _blogService = blogService;
            _pageVisitService = pageVisitService;
        }

        #endregion
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            string currentPageUrl = HttpContext.Request.Path;
            await _pageVisitService.IncrementVisitCount(currentPageUrl);

            ViewData["AboutMeView"] = await _aboutMeServic.GetAllAboutMeViewModel();
            ViewData["ItemListView"] = await _itemServic.GetAllItem();
            ViewData["SkillListView"] = await _skillServic.GetAllSkill();
            ViewData["PortfolioCategoryList"] = await _portfolioCategoryServic.GetAllPortfolioCategory();
            ViewData["PortfolioList"] = await _portfolioServic.GetAllPortfolio();
            ViewData["ThingIDoList"] = await _thingIDoServic.GetAllThingIDo();
            ViewData["CustomerFeedbackList"] = await _customerFeedbackServic.GetAllCustomerFeedback();
            ViewData["CustomerLogoList"] = await _customerLogoServic.GetAllCustomerLogo();
            ViewData["EducationList"] = await _educationServic.GetAllEducation();
            ViewData["ExperiencList"] = await _experienceServic.GetAllExperience();
            ViewData["InformationView"] = await _informationService.GetAllInformation();
            ViewData["BlogListView"] = await _blogService.GetAllBlog();
            await _pageVisitService.RecordVisitAsync();

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(MessageViewModel message)
        {
            string currentPageUrl = HttpContext.Request.Path;

            ViewData["AboutMeView"] = await _aboutMeServic.GetAllAboutMeViewModel();
            ViewData["ItemListView"] = await _itemServic.GetAllItem();
            ViewData["SkillListView"] = await _skillServic.GetAllSkill();
            ViewData["PortfolioCategoryList"] = await _portfolioCategoryServic.GetAllPortfolioCategory();
            ViewData["PortfolioList"] = await _portfolioServic.GetAllPortfolio();
            ViewData["ThingIDoList"] = await _thingIDoServic.GetAllThingIDo();
            ViewData["CustomerFeedbackList"] = await _customerFeedbackServic.GetAllCustomerFeedback();
            ViewData["CustomerLogoList"] = await _customerLogoServic.GetAllCustomerLogo();
            ViewData["EducationList"] = await _educationServic.GetAllEducation();
            ViewData["ExperiencList"] = await _experienceServic.GetAllExperience();
            ViewData["InformationView"] = await _informationService.GetAllInformation();
            ViewData["BlogListView"] = await _blogService.GetAllBlog();
            await _pageVisitService.RecordVisitAsync();

            if (!await _captchaValidator.IsCaptchaPassedAsync(message.Captcha))
            {
                TempData[ErrorMessage] = "کپچا با شکست مواجه شد";
                return View(message);
            }

            if (!ModelState.IsValid)
            {
                return View(message);
            }

            var result = await _messageService.CreateMessage(message);

            if (result)
            {
                TempData[SuccessMessage] = "ارسال پیام با موفقیت انجام شد";
            }

            return View();
        }



    }
}
