using Microsoft.EntityFrameworkCore;
using Resume.Application.Services.Interfaces;
using Resume.Domain.Models;
using Resume.Domain.ViewModels.Portfolio;
using Resume.Infra.Data.Context;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resume.Application.Services.Implementations
{
    public class PortfolioService : IPortfolioService
    {
        #region Cunstructor
        private readonly AppDbContext _dbcontext;
        private readonly IPortfolioCategoryService _portfolioCategoryService;

        public PortfolioService(AppDbContext dbContext, IPortfolioCategoryService portfolioCategoryService)
        {
            _dbcontext = dbContext;
            _portfolioCategoryService = portfolioCategoryService;

        }
        #endregion

        public async Task<bool> CreateOrEditPortfolioViewModel(CreateOrEditPortfolioViewModel portfolio)
        {
            if(portfolio.Id == 0)
            {
                var newPortfolio = new Portfolio()
                {
                    Image = portfolio.Image,
                    ImageAlt = portfolio.ImageAlt,
                    Link = portfolio.Link,
                    Order = portfolio.Order,
                    Title = portfolio.Title,
                    PortfolioCategoryId = portfolio.PortfolioCategoryId
                };

                await _dbcontext.AddAsync(newPortfolio);
                await _dbcontext.SaveChangesAsync();

                return true;
            }


            var currentPortfolio = await GetPortfolioById(portfolio.Id);

            if(currentPortfolio == null)
            {
                return false;
            }

            currentPortfolio.Id = portfolio.Id;
            currentPortfolio.Order = portfolio.Order;
            currentPortfolio.Image = portfolio.Image;
            currentPortfolio.ImageAlt = portfolio.ImageAlt;
            currentPortfolio.PortfolioCategoryId = portfolio.PortfolioCategoryId;
            currentPortfolio.Link = portfolio.Link;

            _dbcontext.Portfolios.Update(currentPortfolio);
            await _dbcontext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeletePortfolio(long id)
        {
            var portfolio = await GetPortfolioById(id);

            if(portfolio == null)
            {
                return false;
            }

            _dbcontext.Portfolios.Remove(portfolio);
            await _dbcontext.SaveChangesAsync();
            return true;
        }

        public async Task<CreateOrEditPortfolioViewModel> FillCreateOrEditPortfolioViewModel(long id)
        {
            if (id == 0)
            {
                return new CreateOrEditPortfolioViewModel() 
                { 
                    Id = 0,
                    PortfolioCategory = await _portfolioCategoryService.GetAllPortfolioCategory()

                };

            }
            var currentPortfolio = await GetPortfolioById(id);

            if (currentPortfolio == null)
            {
                return new CreateOrEditPortfolioViewModel() { 
                    
                    Id = 0,
                    PortfolioCategory = await _portfolioCategoryService.GetAllPortfolioCategory()
                };

            }

            return new CreateOrEditPortfolioViewModel()
            {
                Id = currentPortfolio.Id,
                Image = currentPortfolio.Image,
                ImageAlt = currentPortfolio.ImageAlt,
                Link = currentPortfolio.Link,
                Order = currentPortfolio.Order,
                PortfolioCategory = await _portfolioCategoryService.GetAllPortfolioCategory(),
                PortfolioCategoryId = currentPortfolio.PortfolioCategoryId,
                Title = currentPortfolio.Title
            };
        }




        public async Task<List<PortfolioViewModel>> GetAllPortfolio()
        {
            List<PortfolioViewModel> portfolio = await _dbcontext.Portfolios.OrderBy(p => p.Order)
                .Select(p => new PortfolioViewModel()
                {
                    Id = p.Id,
                    Image = p.Image,
                    Order = p.Order,
                    ImageAlt = p.ImageAlt,
                    Link = p.Link,
                    Title = p.Title,
                    PortfolioCategoryName = p.PortfolioCategory.Name

                }).ToListAsync();

            return portfolio;
        }

        public async Task<Portfolio> GetPortfolioById(long id)
        {
            return await _dbcontext.Portfolios.FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}
