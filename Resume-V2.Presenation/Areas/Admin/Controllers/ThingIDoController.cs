using Microsoft.AspNetCore.Mvc;
using Resume_V2.Application.DTOs;
using Resume_V2.Application.Services.Interfaces;

namespace Resume_V2.Presenation.Areas.Admin.Controllers
{
    public class ThingIDoController : AdminBaseController
    {
        #region Constructor
        private readonly IThingIDo _thingIDoService;
        public ThingIDoController(IThingIDo thingIDoService)
        {
            _thingIDoService = thingIDoService;
        }
        #endregion
        public async Task<IActionResult> Index()
        {
            var model = await _thingIDoService.GetAllThingIDo();
            return View(model);
        }

        public async Task<IActionResult> LoadThingIDoFormModal(long id)
        {
            var resualt = await _thingIDoService.FillCreateOrEditThingIDo(id);
            return PartialView("_ThingIDoModalPartial", resualt);
        }
        public async Task<IActionResult> SubmitThingIDFormModal(CreateOrEditThingIDo thingIDo)
        {
            var resualt = await _thingIDoService.CreateOrEditThingIDo(thingIDo);

            if (resualt)
            {
                return new JsonResult(new {status = "Success"});
            }

            return new JsonResult(new { status = "Erorr" });
        }
    }
}
