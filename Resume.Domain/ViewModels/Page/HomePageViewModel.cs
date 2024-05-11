using Resume.Domain.ViewModels.Information;
using Resume.Domain.ViewModels.SocialMedia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Domain.ViewModels.Page
{
    public class HomePageViewModel
    {
        public List<SocialMediaViewModel> SocialMediaList { get; set; }
        public InformationViewModel informationView { get; set; }
    }
}
