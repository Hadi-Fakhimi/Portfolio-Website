﻿using Resume.Domain.ViewModels.AboutMe;
using Resume.Domain.ViewModels.CustomerFeedback;
using Resume.Domain.ViewModels.CustomerLogo;
using Resume.Domain.ViewModels.Education;
using Resume.Domain.ViewModels.ItemIDo;
using Resume.Domain.ViewModels.ThingIDo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Domain.ViewModels.Page
{
    public class IndexPageViewModel
    {
        public List<ThingIDoListViewModel>  ThingIDoList { get; set; }
        public List<CustomerFeedbackViewModel> CustomerFeedbackList { get; set; }
        public List<CustomerLogoListViewModel> CustomerLogoList { get; set; }
        public List<ItemIDoViewModel> ItemIDoList { get; set; }
        public AboutMeViewModel AboutMeView { get; set; }


    }
}
