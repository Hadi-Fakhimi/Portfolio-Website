using Microsoft.AspNetCore.Mvc;
using Resume_V2.Application.Services.Impelementations;
using Resume_V2.Application.Services.Interfaces;

namespace Resume_V2.Presenation.Controllers
{
    public class BlogController : BaseController
    {
        #region Constructor
        private readonly IBlogPage _blogPage;
        private readonly IInformation _information;
        private readonly IPageVisit _pageVisitService;
        public BlogController(IBlogPage blogPage, IInformation information, IPageVisit pageVisitService)
        {
            _blogPage = blogPage;
            _information = information;
            _pageVisitService = pageVisitService;
        }
        #endregion
        [HttpGet("Blog/{id}")]
        public async Task<IActionResult> Index(long id)
        {
            string currentPageUrl = HttpContext.Request.Path;
            await _pageVisitService.IncrementVisitCount(currentPageUrl);
            ViewData["PageVisitView"] = await _pageVisitService.GetVisitCount(currentPageUrl);
            var blog =  await _blogPage.GetBlogPageById(id);
            if (blog.Id == 0)
            {
                return NotFound();
            }
            return View(blog);
        }
    }
}
