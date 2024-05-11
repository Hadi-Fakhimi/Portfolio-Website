using Microsoft.AspNetCore.Mvc;
using Resume.Application.Services.Interfaces;
using Resume.Domain.ViewModels.ThingIDo;
using System.Net.WebSockets;
using System.Threading.Tasks;

namespace Resume.Presentation.Areas.Admin.Controllers
{
    public class ThingIDoController : AdminBaseController
    {

        #region Constructor
        private readonly IThingIDoService _thingIDoService;

        public ThingIDoController(IThingIDoService thingIDoService)
        {
            _thingIDoService = thingIDoService;
        }


        #endregion

        public async Task<IActionResult>  Index()
        {
            return View(await _thingIDoService.GetAllThingIDoForIndex());
        }

        public async Task<IActionResult> LoadThingIDoFormModal(long id)
        {
            CreateOrEditThingIDoViewModel result = await _thingIDoService.FillCreateOrEditThingIDoViewModel(id);

            return PartialView("_ThingIDoModalPartial", result);
        }

        public async Task<IActionResult> SubmitThingIDoFormModal(CreateOrEditThingIDoViewModel thingIDo)
        {
            var result = await _thingIDoService.CreateOrEditThingIDo(thingIDo);
            if (result)
            {
                return new JsonResult(new {status = "Success"});
            }

            return new JsonResult(new {status = "Error"});
            
        }

        public async Task<IActionResult> DeleteThingIDo(long id)
        {
            var result = await _thingIDoService.DeleteThingIDo(id);

            if (result) return new JsonResult(new {status = "Success"});

            return new JsonResult(new { status = "Error" });
        }
    }
}
