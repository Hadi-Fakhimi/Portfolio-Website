using Microsoft.AspNetCore.Mvc;
using Resume.Application.Services.Interfaces;
using Resume.Domain.ViewModels.PortfolioCategory;
using System.Threading.Tasks;

namespace Resume.Presentation.Areas.Admin.Controllers
{
    public class PortfolioCategoryController : AdminBaseController
    {
        #region Constructor

        private readonly IPortfolioCategoryService _portfolioCategoryService;
        public PortfolioCategoryController(IPortfolioCategoryService portfolioCategoryService)
        {
            _portfolioCategoryService = portfolioCategoryService;
        }

        #endregion
        public async Task<IActionResult> Index()
        {
            return View(await _portfolioCategoryService.GetAllPortfolioCategory());
        }

        public async Task<IActionResult> LoadPortfolioCategoryFormModal(long id)
        {
            var result = await _portfolioCategoryService.FillCreateOrEditPortfolioCategoryViewModel(id);
            return PartialView("_PortfolioCategoryModalPartial", result);
        }

        public async Task<IActionResult> SubmitPortfolioCategoryFormModal(CreateOrEditPortfolioCategoryViewModel portfolioCatgory)
        {
            var result = await _portfolioCategoryService.CreateOrEditPortfolioCategoryViewModel(portfolioCatgory);
            if (result)
            {
                return new JsonResult(new { status = "Success" });
            }
            return new JsonResult(new { status = "Erorr" });
        }

        public async Task<IActionResult> DeletePortfolioCategory(long id)
        {
            var result = await _portfolioCategoryService.DeletePortfolioCategory(id);
            if (result)
            {
                return new JsonResult(new { status = "Success" });
            }

            return new JsonResult(new { status = "Erorr" });
        }
    }
}
