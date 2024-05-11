using Microsoft.EntityFrameworkCore;
using Resume.Application.Services.Interfaces;
using Resume.Domain.Models;
using Resume.Domain.ViewModels.PortfolioCategory;
using Resume.Infra.Data.Context;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resume.Application.Services.Implementations
{
    public class PortfolioCategoryService : IPortfolioCategoryService
    {
        #region Constructor
        private readonly AppDbContext _dbContext;

        public PortfolioCategoryService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        #endregion

        public async Task<bool> CreateOrEditPortfolioCategoryViewModel(CreateOrEditPortfolioCategoryViewModel portfolioCategory)
        {
            if (portfolioCategory.Id == 0)
            {
                var newPortfolioCategory = new PortfolioCategory
                {
                    Name = portfolioCategory.Name,
                    Order = portfolioCategory.Order,
                    Title = portfolioCategory.Title,
                };

                await _dbContext.PortfolioCategories.AddAsync(newPortfolioCategory);
                await _dbContext.SaveChangesAsync();

                return true;
            }

            var currentPortfolioCategory = await GetPortfolioCategoryById(portfolioCategory.Id);

            if(currentPortfolioCategory == null)
            {
                return false;
            }


            currentPortfolioCategory.Order = portfolioCategory.Order;
            currentPortfolioCategory.Title = portfolioCategory.Title;
            currentPortfolioCategory.Name = portfolioCategory.Name;


            _dbContext.PortfolioCategories.Update(currentPortfolioCategory);
            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeletePortfolioCategory(long id)
        {
            var portfolioCategory = await GetPortfolioCategoryById(id);

            if(portfolioCategory == null)
            {
                return false;
            }

            _dbContext.PortfolioCategories.Remove(portfolioCategory);

            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<CreateOrEditPortfolioCategoryViewModel> FillCreateOrEditPortfolioCategoryViewModel(long id)
        {
            if (id == 0)
            {
                return new CreateOrEditPortfolioCategoryViewModel() { Id = 0 };
            }

            var currentPortfolioCategory = await GetPortfolioCategoryById(id);

            if (currentPortfolioCategory == null)
            {
                return new CreateOrEditPortfolioCategoryViewModel() { Id = 0 };
            }

            return new CreateOrEditPortfolioCategoryViewModel()
            {
                Id = currentPortfolioCategory.Id,
                Name = currentPortfolioCategory.Name,
                Order = currentPortfolioCategory.Order,
                Title = currentPortfolioCategory.Title
            };
        }


        public async Task<List<PortfolioCategoryViewModel>> GetAllPortfolioCategory()
        {
            List<PortfolioCategoryViewModel> portfolioCategory = await _dbContext.PortfolioCategories.OrderBy(p => p.Order)
                .Select(p => new PortfolioCategoryViewModel()
                {
                    Id = p.Id,
                    Name = p.Name,
                    Order = p.Order,
                    Title = p.Title
                }).ToListAsync();


            return portfolioCategory;
        }

        public async Task<PortfolioCategory> GetPortfolioCategoryById(long id)
        {
            return await _dbContext.PortfolioCategories.FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}
