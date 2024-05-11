using Microsoft.AspNetCore.Mvc;
using Resume.Application.Services.Interfaces;
using System.Threading.Tasks;

namespace Resume.Presentation.Areas.Admin.Controllers
{
    public class HomeController : AdminBaseController
    {
        #region Constructor

        private readonly IMessageService _messageService;
        public HomeController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        #endregion
        public async Task<IActionResult> Index()
        {
            TempData[SuccessMessage] = "عملیات با موفقیت ثبت شد";
            return View(await _messageService.GetAllMessages());
        }

        public async Task<IActionResult> DeleteMessage(long id)
        {
            var result = await _messageService.DeleteMessage(id);

            if (result)
            {
                return new JsonResult(new { status = "Success" });
            }

            return new JsonResult(new { status = "Erorr" });
        }
    }
}
