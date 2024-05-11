using Microsoft.AspNetCore.Mvc;
using Resume.Application.Services.Interfaces;
using Resume.Domain.ViewModels.Page;
using System.Threading.Tasks;

namespace Resume.Presentation.Controllers
{
    public class PortfolioController : Controller
    {
        #region Constructor
        private readonly IPortfolioService _portfolioService;
        private readonly IPortfolioCategoryService _portfolioCategoryService;

        public PortfolioController(IPortfolioService portfolioService,IPortfolioCategoryService portfolioCategoryService)
        {
            _portfolioCategoryService = portfolioCategoryService;
            _portfolioService = portfolioService;
        }
        #endregion
        public async Task<IActionResult> Index()
        {
            PortfolioPageViewModel model = new PortfolioPageViewModel() 
            {
                Portfolio = await _portfolioService.GetAllPortfolio(),
                PortfolioCategory = await _portfolioCategoryService.GetAllPortfolioCategory()
            };
            return View(model);
        }
    }
}
