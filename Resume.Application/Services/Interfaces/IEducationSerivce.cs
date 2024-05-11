using Resume.Domain.Models;
using Resume.Domain.ViewModels.Education;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.Services.Interfaces
{
    public interface IEducationSerivce
    {
        Task<Education> GetEducationById(long id);
        Task<List<EducationViewModel>> GetEducationForIndexPage();

        Task<CreateOrEditEducationViewModel> FillCreateOrEditEducationViewModel(long id);

        Task<bool> CreateOrEditeEducation(CreateOrEditEducationViewModel education); 

        Task<bool> DeleteEducation(long id);

    }
}
