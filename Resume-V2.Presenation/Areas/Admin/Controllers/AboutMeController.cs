using Microsoft.AspNetCore.Mvc;
using Resume_V2.Application.DTOs;
using Resume_V2.Application.Generator;
using Resume_V2.Application.Services.Interfaces;
using Resume_V2.Application.StaticTools;
using Resume_V2.Application.Extensions;
using System.CodeDom.Compiler;

namespace Resume_V2.Presenation.Areas.Admin.Controllers
{
    public class AboutMeController : AdminBaseController
    {
        #region Constructor
        private readonly IAboutMe _aboutMeService;
        public AboutMeController(IAboutMe aboutMeService)
        {
            _aboutMeService = aboutMeService;
        }
        #endregion


    }
}
