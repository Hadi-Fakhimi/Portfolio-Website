using Resume.Domain.Models;
using Resume.Domain.ViewModels.AboutMe;
using System.Threading.Tasks;

namespace Resume.Application.Services.Interfaces
{
    public interface IAboutMeService
    {
        Task<AboutMe> GetAboutMeViewModelById(long id);
        Task<AboutMeViewModel> GetAllAboutMeForIndex();
        Task<CreateOrEditAboutMeViewModel> FillCreateOrEditAboutMeViewModel(long id);
        Task<bool> CreateOrEditAboutMe(CreateOrEditAboutMeViewModel aboutMe);
        Task<bool> DeleteAboutMe(long id);

    }
}
