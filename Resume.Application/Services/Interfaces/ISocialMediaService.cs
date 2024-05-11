using Resume.Domain.Models;
using Resume.Domain.ViewModels.Education;
using Resume.Domain.ViewModels.SocialMedia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.Services.Interfaces
{
    public interface ISocialMediaService
    {
        Task<List<SocialMediaViewModel>> GetAllSocialMedias();

        Task<SocialMedia> GetSocialMediaById(long id);

        Task<CreateOrEditSocialMediaViewModel> FillCreateOrEditSocialMediaViewModel(long id);

        Task<bool> CreateOrEditeSocialMedia(CreateOrEditSocialMediaViewModel socialMedia);

        Task<bool> DeleteSocialMedia(long id);

    }
}
