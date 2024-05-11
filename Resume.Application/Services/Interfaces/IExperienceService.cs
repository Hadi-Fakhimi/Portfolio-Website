using Resume.Domain.Models;
using Resume.Domain.ViewModels.Experience;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.Services.Interfaces
{
    public interface IExperienceService
    {
        Task<Experience> GetExperienceById(long id);
        Task<List<ExperienceViewModel>> GetExperienceForIndexPage();
        Task<CreateOrEditExperienceViewModel> FillCreateOrEditExperienceViewModel(long id);
        Task<bool> CreateOrEditExperience(CreateOrEditExperienceViewModel experience);
        Task<bool> DeleteExperience(long id);



    }
}
