using Microsoft.EntityFrameworkCore;
using Resume.Application.Services.Interfaces;
using Resume.Domain.Models;
using Resume.Domain.ViewModels.CustomerFeedback;
using Resume.Domain.ViewModels.CustomerLogo;
using Resume.Infra.Data.Context;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resume.Application.Services.Implementations
{
    public class CustomerLogoService : ICustomerLogoService
    {
        #region Constructor
        private readonly AppDbContext _dbContext;
        public CustomerLogoService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        #endregion
        public async Task<bool> CreateOrEditeCustomerLogoViewModel(CreateOrEditCustomerLogoListViewModel customerLogo)
        {
            if (customerLogo.Id == 0)
            {
                var newCustomerLogo = new CustomerLogo()
                {
                    Link = customerLogo.Link,
                    Order = customerLogo.Order,
                    Logo = customerLogo.Logo,
                    LogoAlt = customerLogo.LogoAlt
                    
                };

                await _dbContext.CustomerLogos.AddAsync(newCustomerLogo);

                await _dbContext.SaveChangesAsync();
                return true;
            }

            var currentCustomerLogo = await GetCustomerLogoById(customerLogo.Id);

            if (currentCustomerLogo == null)
            {
                return false;
            }
            currentCustomerLogo.Link = customerLogo.Link;
            currentCustomerLogo.Order = customerLogo.Order;
            currentCustomerLogo.Logo = customerLogo.Logo;
            currentCustomerLogo.LogoAlt = customerLogo.LogoAlt;

            _dbContext.CustomerLogos.Update(currentCustomerLogo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteCustomerLogo(long id)
        {
            CustomerLogo customerLogo = await GetCustomerLogoById(id);
            if (customerLogo == null)
            {
                return false;
            }

            _dbContext.CustomerLogos.Remove(customerLogo);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<CreateOrEditCustomerLogoListViewModel> FillCreateOrEditCustomerLogoViewModel(long id)
        {
            if (id == 0)
            {
                return new CreateOrEditCustomerLogoListViewModel() { Id = 0 };

            }

            CustomerLogo customerLogo = await GetCustomerLogoById(id);

            if (customerLogo == null)
            {
                return new CreateOrEditCustomerLogoListViewModel() { Id = 0 };

            }

            return new CreateOrEditCustomerLogoListViewModel()
            {
                Link = customerLogo.Link,
                Order = customerLogo.Order,
                Logo = customerLogo.Logo,
                LogoAlt = customerLogo.LogoAlt,
                Id = customerLogo.Id
            };
        }

        public async Task<CustomerLogo> GetCustomerLogoById(long id)
        {
            return await _dbContext.CustomerLogos.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<List<CustomerLogoListViewModel>> GetCustomerLogosForIndexPage()
        {
            List<CustomerLogoListViewModel> customerLogos = await _dbContext.CustomerLogos
                .OrderBy(c => c.Order)
                .Select(c => new CustomerLogoListViewModel()
                {
                    Id = c.Id,
                    Link = c.Link,
                    Order = c.Order,
                    Logo = c.Logo,
                    LogoAlt = c.LogoAlt
                }).ToListAsync();

            return customerLogos;
        }
    }
}
