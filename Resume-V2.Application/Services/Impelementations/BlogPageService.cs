using Microsoft.EntityFrameworkCore;
using Resume_V2.Application.DTOs;
using Resume_V2.Application.Services.Interfaces;
using Resume_V2.Infra.Data.AppContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume_V2.Application.Services.Impelementations
{
    public class BlogPageService : IBlogPage
    {
        #region Constructor
        private readonly AppDbContext _context;
        public BlogPageService(AppDbContext context)
        {
            _context = context;
        }
        #endregion
        public async Task<BlogPageViewModel> GetBlogPageById(long id)
        {
            var blogPage = await _context.Blogs.Include(bc =>bc.BlogCategory).FirstOrDefaultAsync(b => b.Id == id);
            if (blogPage == null) 
            {
                return new BlogPageViewModel();
            }
            BlogPageViewModel blogPageViewModel = new BlogPageViewModel()
            {
                Date = blogPage.Date,
                DescriptionImage = blogPage.DescriptionImage,
                DescriptionImage2 = blogPage.DescriptionImage2,
                DescriptionText = blogPage.DescriptionText,
                DescriptionText2 = blogPage.DescriptionText2,
                DescriptionTitle = blogPage.DescriptionTitle,
                DescriptionTitle2 = blogPage.DescriptionTitle2,
                Image = blogPage.Image,
                Publisher = blogPage.Publisher,
                Title = blogPage.Title,
                Id = blogPage.Id,
                CategoryName = blogPage.BlogCategory.Name
            };

            return blogPageViewModel;

        }
    }
}
