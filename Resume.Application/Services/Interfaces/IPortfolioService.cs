using Resume.Domain.Models;
using Resume.Domain.ViewModels.Portfolio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.Services.Interfaces
{
    public interface IPortfolioService
    {
        Task<Portfolio> GetPortfolioById(long id);
        Task<List<PortfolioViewModel>> GetAllPortfolio();
        Task<CreateOrEditPortfolioViewModel> FillCreateOrEditPortfolioViewModel(long id);
        Task<bool> CreateOrEditPortfolioViewModel(CreateOrEditPortfolioViewModel portfolio);
        Task<bool> DeletePortfolio(long id);
    }
}
