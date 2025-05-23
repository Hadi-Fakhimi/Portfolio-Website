using Microsoft.AspNetCore.Mvc;
using Resume_V2.Application.Services.Impelementations;
using Resume_V2.Application.Services.Interfaces;

namespace Resume_V2.Presenation.Areas.Admin.Controllers
{
    public class HomeController : AdminBaseController
    {
        #region Constructor
        private readonly IPageVisit _pageVisitService;
        public HomeController(IPageVisit pageVisitService)
        {
            _pageVisitService = pageVisitService;
        }
        #endregion
        public async Task<IActionResult> Index()
        {
            TempData[SuccessMessage] = "عملیات با موفقیت ثبت شد";
            ViewData["GetDailyRecords"] = await _pageVisitService.GetDailyVisitsAsync();
            ViewData["GetWeeklyRecords"] = await _pageVisitService.GetWeeklyVisitsAsync();
            ViewData["GetMonthlyRecords"] = await _pageVisitService.GetMonthlyVisitsAsync();
            return View();
        }
    }
}
