using Resume.Domain.Models;
using Resume.Domain.ViewModels.PortfolioCategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.Services.Interfaces
{
    public interface IPortfolioCategoryService
    {
        Task<PortfolioCategory> GetPortfolioCategoryById(long id);
        Task<List<PortfolioCategoryViewModel>> GetAllPortfolioCategory();
        Task<CreateOrEditPortfolioCategoryViewModel> FillCreateOrEditPortfolioCategoryViewModel(long id);
        Task<bool> CreateOrEditPortfolioCategoryViewModel(CreateOrEditPortfolioCategoryViewModel portfolioCategory);
        Task<bool> DeletePortfolioCategory(long id);
    }
}
