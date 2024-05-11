using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Resume.Application.Extensions;
using Resume.Application.Generator;
using Resume.Application.Services.Interfaces;
using Resume.Application.StaticTools;
using Resume.Domain.ViewModels.Portfolio;
using System.IO;
using System.Threading.Tasks;

namespace Resume.Presentation.Areas.Admin.Controllers
{
    public class PortfolioController : AdminBaseController
    {
        #region Cunstructor

        private readonly IPortfolioService _portfolioService;
        public PortfolioController(IPortfolioService portfolioService)
        {
            _portfolioService = portfolioService;
        }

        #endregion
        public async Task<IActionResult> Index()
        {
            return View(await _portfolioService.GetAllPortfolio());
        }

        public async Task<IActionResult> LoadPortfolioFormModal(long id) 
        {
            var result = await _portfolioService.FillCreateOrEditPortfolioViewModel(id);
            return PartialView("_PortfolioModalPartial", result);
        }

        public async Task<IActionResult> SubmitPortfolioFormModal(CreateOrEditPortfolioViewModel portfolio)
        {
            var result = await _portfolioService.CreateOrEditPortfolioViewModel(portfolio);

            if (result)
            {
                return new JsonResult(new { status = "Success" });
            }

            return new JsonResult(new { status = "Error" });
        }

        public async Task<IActionResult> DeletePortfolio(long id)
        {
            var result = await _portfolioService.DeletePortfolio(id);

            if(result)
            {
                return new JsonResult(new { status = "Success" });
            }

            return new JsonResult(new { status = "Erorr" });
        }


        [HttpPost]
        public async Task<IActionResult> UploadPortfolioAjaxImage(IFormFile file)
        {
            if(file != null)
            {
                if(Path.GetExtension(file.FileName) == ".png" || Path.GetExtension(file.FileName) == ".svg" || Path.GetExtension(file.FileName) == ".jpg")
                {
                    var imageName = CodeGenerator.GenerateUniqCode() + Path.GetExtension(file.FileName);
                    await file.AddImageAjaxToServer(imageName, FilePaths.PortfolioImgServer);

                    return new JsonResult(new { status = "Success", imageName = imageName });

                }
                else
                {
                    return new JsonResult(new { status = "Error" });
                }
            }
            else
            {
                return new JsonResult(new { status = "Erorr" });
            }

        }

    }
}
