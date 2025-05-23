using Microsoft.EntityFrameworkCore;
using Resume_V2.Application.DTOs;
using Resume_V2.Application.Services.Interfaces;
using Resume_V2.Infra.Data.AppContext;

namespace Resume_V2.Application.Services.Impelementations
{
    public class PortfolioService : IPortfolio
    {
        #region Constructor
        private readonly AppDbContext _context;
        private readonly IPortfolioCategory _portfolioCategory;
        public PortfolioService(AppDbContext context, IPortfolioCategory portfolioCategory)
        {
            _context = context;
            _portfolioCategory = portfolioCategory;
        }

        #endregion
        public async Task<List<PortfolioViewModel>> GetAllPortfolio()
        {
            List<PortfolioViewModel> portfolios = await _context.Portfolios.OrderBy(p => p.Order)
                .Select( p => new PortfolioViewModel()
                {
                    Id = p.Id,
                    Image = p.Image,
                    Title = p.Title,
                    Order = p.Order,
                    ImageAlt = p.ImageAlt,
                    Link = p.Link,
                    PortfoioCategoryName = p.PortfolioCategory.Name,
                    PortfoioCategoryTitle = p.PortfolioCategory.Title
                }).ToListAsync();

            return portfolios;
        }
    }
}
