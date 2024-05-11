using Microsoft.EntityFrameworkCore;
using Resume.Application.Services.Interfaces;
using Resume.Domain.Models;
using Resume.Domain.ViewModels.CustomerFeedback;
using Resume.Infra.Data.Context;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resume.Application.Services.Implementations
{
    public class CustomerFeedbackService : ICustomerFeedbackService
    {
        #region Constructor
        private readonly AppDbContext _dbContext;
        public CustomerFeedbackService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        #endregion


        public async Task<CustomerFeedback> GetCustomerFeedbackById(int id)
        {
            return await _dbContext.CustomerFeedbacks.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<bool> CreateOrEditCustomerFeedback(CreateOrEditCustomerFeedbackViewModel customerFeedback)
        {
            if (customerFeedback.Id == 0)
            {
                var newCustomerFeedback = new CustomerFeedback()
                {
                    Avatar = customerFeedback.Avatar,
                    Order = customerFeedback.Order,
                    AboutJob = customerFeedback.AboutJob,
                    Description = customerFeedback.Description,
                    Name = customerFeedback.Name
                };

                await _dbContext.CustomerFeedbacks.AddAsync(newCustomerFeedback);

                await _dbContext.SaveChangesAsync();
                return true;
            }

            var currentCustomerFeedback = await GetCustomerFeedbackById(customerFeedback.Id);

            if (currentCustomerFeedback == null)
            {
                return false;
            }

            currentCustomerFeedback.Avatar = customerFeedback.Avatar;
            currentCustomerFeedback.Order = customerFeedback.Order;
            currentCustomerFeedback.Name = customerFeedback.Name;
            currentCustomerFeedback.AboutJob = customerFeedback.AboutJob;
            currentCustomerFeedback.Description = customerFeedback.Description;

            _dbContext.CustomerFeedbacks.Update(currentCustomerFeedback);
            await _dbContext.SaveChangesAsync();
            return true;
        }
        public async Task<List<CustomerFeedbackViewModel>> GetCustomerFeedbackForIndex()
        {
            List<CustomerFeedbackViewModel> customerFeedbacks = await _dbContext.CustomerFeedbacks
                .OrderBy(c=>c.Order)
                .Select(c => new CustomerFeedbackViewModel()
                {
                    Order = c.Order,
                    Avatar = c.Avatar,
                    Description = c.Description,
                    Id = c.Id,
                    Name = c.Name

                }).ToListAsync();

            return customerFeedbacks;
        }

        public async Task<CreateOrEditCustomerFeedbackViewModel> FillCreateOrEditCustomerFeedbackViewModel(int id)
        {
            if(id == 0)
            {
                return new CreateOrEditCustomerFeedbackViewModel() { Id = 0 };

            }

            CustomerFeedback customerFeedback = await GetCustomerFeedbackById(id);

            if (customerFeedback == null)
            {
                return new CreateOrEditCustomerFeedbackViewModel() { Id = 0 };

            }

            return new CreateOrEditCustomerFeedbackViewModel()
            {
                Avatar = customerFeedback.Avatar,
                Description = customerFeedback.Description,
                AboutJob = customerFeedback.AboutJob,
                Name = customerFeedback.Name,
                Order = customerFeedback.Order,
                Id = customerFeedback.Id
            };
        }

        public async Task<bool> DeleteCustomerFeedback(int id)
        {
            CustomerFeedback customerFeedback = await GetCustomerFeedbackById(id);
            if (customerFeedback == null)
            {
                return false;
            }

            _dbContext.CustomerFeedbacks.Remove(customerFeedback);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
