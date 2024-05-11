using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Resume.Application.Extensions;
using Resume.Application.Generator;
using Resume.Application.Services.Interfaces;
using Resume.Application.StaticTools;
using Resume.Domain.ViewModels.Information;
using System.IO;
using System.Threading.Tasks;

namespace Resume.Presentation.Areas.Admin.Controllers
{
    public class InformationController : AdminBaseController
    {
        #region Constructor
        private readonly IInformationService _informationService;
        public InformationController(IInformationService informationService)
        {
            _informationService = informationService;
        }

        #endregion
        public async Task<IActionResult> Index()
        {
            return View(await _informationService.GetInformation());
        }

        public async Task<IActionResult> LoadInformationFormModal(long id)
        {
            var result = await _informationService.FillCreateOrEditInformationViewModel(id);

            return PartialView("_InformationModalPartial",result);
        }

        public async Task<IActionResult> SubmitInformationFormModal(CreateOrEditInformationViewModel information)
        {
            var result = await _informationService.CreateOrEditInformationViewModel(information);

            if (result)
            {
                return new JsonResult(new { status = "Success" });
            }

            return new JsonResult(new { status = "Error" });
        }


        public async Task<IActionResult> DeleteInformation(long id)
        {
            var result = await _informationService.DeleteInformation(id);

            if (result)
            {
                return new JsonResult(new { status = "Success" });
            }

            return new JsonResult(new { status = "Erorr" });
        }

        [HttpPost]
        public async Task<IActionResult> UploadInformationAjaxImage(IFormFile file)
        {
            if (file != null)
            {
                if (Path.GetExtension(file.FileName) == ".png" || Path.GetExtension(file.FileName) == ".svg" || Path.GetExtension(file.FileName) == ".jpg")
                {
                    var imageName = CodeGenerator.GenerateUniqCode() + Path.GetExtension(file.FileName);
                    await file.AddImageAjaxToServer(imageName, FilePaths.AvatarImgServer);

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

        [HttpPost]
        public async Task<IActionResult> UploadInformationAjaxPdf(IFormFile file)
        {
            if (file != null)
            {
                if (Path.GetExtension(file.FileName) == ".pdf")
                {
                    var pdfName = CodeGenerator.GenerateUniqCode() + Path.GetExtension(file.FileName);
                    await file.AddImageAjaxToServer(pdfName, FilePaths.ResumeServer);

                    return new JsonResult(new { status = "Success", pdfName = pdfName });
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
