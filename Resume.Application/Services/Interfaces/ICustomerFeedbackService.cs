using Resume.Domain.Models;
using Resume.Domain.ViewModels.CustomerFeedback;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.Services.Interfaces
{
    public interface ICustomerFeedbackService
    {
        Task<CustomerFeedback> GetCustomerFeedbackById(int id);
        Task<List<CustomerFeedbackViewModel>> GetCustomerFeedbackForIndex();
        Task<CreateOrEditCustomerFeedbackViewModel> FillCreateOrEditCustomerFeedbackViewModel(int id);
        Task<bool> CreateOrEditCustomerFeedback(CreateOrEditCustomerFeedbackViewModel customerFeedback);
        Task<bool> DeleteCustomerFeedback(int id);
    }
}
