using Microsoft.EntityFrameworkCore;
using Resume_V2.Application.DTOs;
using Resume_V2.Application.Services.Interfaces;
using Resume_V2.Infra.Data.AppContext;

namespace Resume_V2.Application.Services.Impelementations
{
    public class PortfolioCategoryService : IPortfolioCategory
    {
        #region Constructor

        private readonly AppDbContext _context;
        public PortfolioCategoryService(AppDbContext context)
        {
            _context = context;
        }

        #endregion
        public async Task<List<PortfolioCategoryViewModel>> GetAllPortfolioCategory()
        {
            List<PortfolioCategoryViewModel> portfolioCategories = await _context.PortfolioCategories.OrderBy(pc => pc.Order)
                .Select(pc => new PortfolioCategoryViewModel()
                {
                    Name = pc.Name,
                    Order = pc.Order,
                    Title = pc.Title
                }).ToListAsync();

            return portfolioCategories;
        }
    }
}
