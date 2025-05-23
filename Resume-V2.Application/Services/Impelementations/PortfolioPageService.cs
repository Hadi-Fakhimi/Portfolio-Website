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
    public class PortfolioPageService : IPortfolioPage
    {
        #region Constructor
        private readonly AppDbContext _context;
        public PortfolioPageService(AppDbContext context)
        {
            _context = context;
        }
        #endregion
        public async Task<PortfolioPageViewModel> GetPortfoiloById(long id)
        {
            var portfolio = await _context.Portfolios.FirstOrDefaultAsync(p => p.Id == id);
            if (portfolio == null) 
            {
                return new PortfolioPageViewModel();
            }
            PortfolioPageViewModel portfolioPage = new PortfolioPageViewModel() 
            {
                Id = portfolio.Id,
                ClientName = portfolio.ClientName,
                Description = portfolio.Description,
                Image = portfolio.Image,
                ImageAlt = portfolio.ImageAlt,
                ImageDesc = portfolio.ImageDesc,
                Link = portfolio.Link,
                ProjectTime = portfolio.ProjectTime,
                ServiceName = portfolio.ServiceName,
                Title = portfolio.Title
            };

            return portfolioPage;
        }
    }
}
