using Microsoft.AspNetCore.Mvc;
using Resume_V2.Application.Services.Impelementations;
using Resume_V2.Application.Services.Interfaces;

namespace Resume_V2.Presenation.Controllers
{
    public class PortfolioController : BaseController
    {
        #region Constructor
        private readonly IPortfolioPage _portfolioPage;
        private readonly IPageVisit _pageVisitService;
        public PortfolioController(IPortfolioPage portfolioPage, IPageVisit pageVisitService)
        {
            _portfolioPage = portfolioPage;
            _pageVisitService = pageVisitService;
        }
        #endregion
        [HttpGet("Portfolio/{id}")]
        public async Task<IActionResult> Index(long id)
        {
            string currentPageUrl = HttpContext.Request.Path;
            await _pageVisitService.IncrementVisitCount(currentPageUrl);
            ViewData["PageVisitView"] = await _pageVisitService.GetVisitCount(currentPageUrl);
            var portfolio = await _portfolioPage.GetPortfoiloById(id);
            if (portfolio.Id == 0) 
            { 
                return NotFound();
            }

            return View(portfolio);
        }
    }
}
