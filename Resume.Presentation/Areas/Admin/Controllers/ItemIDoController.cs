using Microsoft.AspNetCore.Mvc;
using Resume.Application.Services.Interfaces;
using Resume.Domain.ViewModels.ItemIDo;
using System.Threading.Tasks;

namespace Resume.Presentation.Areas.Admin.Controllers
{
    public class ItemIDoController : AdminBaseController
    {
        #region Constructor

        private readonly IItemIDoService _itemIDoService;
        public ItemIDoController(IItemIDoService itemIDoService)
        {
            _itemIDoService = itemIDoService;
        }
        #endregion
        public async Task<IActionResult> Index()
        {
            return View(await _itemIDoService.GetAllItemIDo());
        }

        public async Task<IActionResult> LoadItemIDoFormModal(long id)
        {
            var result = await _itemIDoService.FillCreateOrEditItemIDoViewModel(id);
            return PartialView("_ItemIDoModalPartial", result);
        }

        public async Task<IActionResult> SubmitItemIDoFormModal(CreateOrEditItemIDoViewModel itemIDo)
        {
            var result = await _itemIDoService.CreateOrEditItemIDoViewModel(itemIDo);

            if (result)
            {
                return new JsonResult(new { status = "Success" });
            }
            return new JsonResult(new { status = "Error" });
        }

        public async Task<IActionResult> DeleteItemIDo(long id)
        {
            var result = await _itemIDoService.DeleteItemIDo(id);
            if (result)
            {
                return new JsonResult(new { status = "Success" });
            }

            return new JsonResult(new {status = "Error"});
        }
    }
}
