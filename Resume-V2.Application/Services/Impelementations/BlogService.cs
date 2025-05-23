using Microsoft.EntityFrameworkCore;
using Resume_V2.Application.DTOs;
using Resume_V2.Application.Services.Interfaces;
using Resume_V2.Infra.Data.AppContext;

namespace Resume_V2.Application.Services.Impelementations
{
    public class BlogService : IBlog
    {
        #region Constructor
        private readonly AppDbContext _context;
        public BlogService(AppDbContext context)
        {
            _context = context;
        }
        #endregion
        public async Task<List<BlogViewModel>> GetAllBlog()
        {
            List<BlogViewModel> bolgs = await _context.Blogs.OrderBy(b => b.Order)
                .Select(b => new BlogViewModel() 
                {
                    Date = b.Date,
                    Image = b.Image,
                    Order = b.Order,
                    Id = b.Id,
                    Title = b.Title,
                    CategoryName = b.BlogCategory.Name
                }).ToListAsync();

            return bolgs;
        }
    }
}
