using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Resume.Application.Extensions;
using Resume.Application.Generator;
using Resume.Application.Services.Interfaces;
using Resume.Application.StaticTools;
using Resume.Domain.ViewModels.CustomerLogo;
using System.IO;
using System.Threading.Tasks;

namespace Resume.Presentation.Areas.Admin.Controllers
{
    public class CustomerLogoController : AdminBaseController
    {
        private readonly ICustomerLogoService _costomerLogoService;
        public CustomerLogoController(ICustomerLogoService costomerLogoService)
        {
            _costomerLogoService = costomerLogoService;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _costomerLogoService.GetCustomerLogosForIndexPage());
        }

        public async Task<IActionResult> LoadCustomerLogoFormModal(int id)
        {
            var result = await _costomerLogoService.FillCreateOrEditCustomerLogoViewModel(id);
            return PartialView("_CustomerLogoModalPartial", result);
        }

        public async Task<IActionResult> SubmitCustomerLogoFormModal(CreateOrEditCustomerLogoListViewModel customerLogo)
        {
            var result = await _costomerLogoService.CreateOrEditeCustomerLogoViewModel(customerLogo);

            if (result)
            {
                return new JsonResult(new { status = "Success" });
            }

            return new JsonResult(new { status = "Error" });
        }

        public async Task<IActionResult> DeleteCustomerLogo(int id)
        {
            var result = await _costomerLogoService.DeleteCustomerLogo(id);

            if (result)
            {
                return new JsonResult(new { status = "Success" });
            }

            return new JsonResult(new { status = "Error" });
        }
        [HttpPost]
        public async Task<IActionResult> UploadCustomerLogoAjaxImage(IFormFile file)
        {
            if (file != null)
            {
                if (Path.GetExtension(file.FileName) == ".png" || Path.GetExtension(file.FileName) == ".svg" || Path.GetExtension(file.FileName) == ".jpg")
                {
                    var imageName = CodeGenerator.GenerateUniqCode() + Path.GetExtension(file.FileName);
                    await file.AddImageAjaxToServer(imageName, FilePaths.CustomerLogoImgServer);

                    return new JsonResult(new { status = "Success", imageName = imageName });
                }
                else
                {
                    return new JsonResult(new { status = "Error" });
                }

            }
            else
            {
                return new JsonResult(new { status = "Error" });
            }
        }
    }
}
