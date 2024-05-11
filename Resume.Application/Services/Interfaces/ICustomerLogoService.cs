using Resume.Domain.Models;
using Resume.Domain.ViewModels.CustomerFeedback;
using Resume.Domain.ViewModels.CustomerLogo;
using Resume.Domain.ViewModels.SocialMedia;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Resume.Application.Services.Interfaces
{
    public interface ICustomerLogoService
    {

        Task<List<CustomerLogoListViewModel>> GetCustomerLogosForIndexPage();

        Task<CustomerLogo> GetCustomerLogoById(long id);

        Task<CreateOrEditCustomerLogoListViewModel> FillCreateOrEditCustomerLogoViewModel(long id);

        Task<bool> CreateOrEditeCustomerLogoViewModel(CreateOrEditCustomerLogoListViewModel customerLogo);


        Task<bool> DeleteCustomerLogo(long id);

    }
}
