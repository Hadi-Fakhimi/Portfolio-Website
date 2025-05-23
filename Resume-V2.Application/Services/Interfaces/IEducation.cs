using Resume_V2.Application.DTOs;
using Resume_V2.Infra.Data.AppContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume_V2.Application.Services.Interfaces
{
    public interface IEducation
    {
        Task<List<EducationViewModel>> GetAllEducation();
    }
}
