using Resume_V2.Application.DTOs;
using Resume_V2.Application.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume_V2.Application.Extensions
{
    public class PanelLayoutScope
    {
        #region Constructor
        private readonly ISocialMedia _socialMedia;
        private readonly IInformation _information;
        public PanelLayoutScope(ISocialMedia socialMedia, IInformation information)
        {
            _socialMedia = socialMedia;
            _information = information;
        }
        #endregion

        public async Task<List<SocialMediaViewModel>> GetSocialMedia()
        {
            return await _socialMedia.GetAllSocialMedia();
        }
        public async Task<InformationViewModel> GetInformation()
        {
            return await _information.GetAllInformation();
        }
    }
}
