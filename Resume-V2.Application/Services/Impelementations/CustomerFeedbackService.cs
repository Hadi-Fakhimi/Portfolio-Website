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
    public class CustomerFeedbackService : ICustomerFeedback
    {
        #region Constructor
        private readonly AppDbContext _context;
        public CustomerFeedbackService(AppDbContext context)
        {
            _context = context;
        }

        #endregion
        public async Task<List<CustomerFeedbackViewModel>> GetAllCustomerFeedback()
        {
            List<CustomerFeedbackViewModel> customerFeedbacks = await _context.CustomerFeedbacks.OrderBy(c => c.Order)
                .Select(c => new CustomerFeedbackViewModel()
                {
                    Order = c.Order,
                    AboutJob = c.AboutJob,
                    Avatar = c.Avatar,
                    Description = c.Description,
                    Name = c.Name,
                    FeedbackScore = c.FeedbackScore
                }).ToListAsync();

            return customerFeedbacks;
        }
    }
}
