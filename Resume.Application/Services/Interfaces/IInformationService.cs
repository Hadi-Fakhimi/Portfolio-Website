using Resume.Domain.Models;
using Resume.Domain.ViewModels.Information;
using System.Threading.Tasks;

namespace Resume.Application.Services.Interfaces
{
    public interface IInformationService
    {
        Task<bool> CreateOrEditInformationViewModel(CreateOrEditInformationViewModel information);
        Task<CreateOrEditInformationViewModel> FillCreateOrEditInformationViewModel(long id);
        Task<bool> DeleteInformation(long id);
        Task<Information> GetInformationViewModelById(long id);
        Task<InformationViewModel> GetInformation();
    }
}
