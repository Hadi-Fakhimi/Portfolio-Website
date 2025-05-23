using Microsoft.EntityFrameworkCore;
using Resume_V2.Application.DTOs;
using Resume_V2.Application.Services.Interfaces;
using Resume_V2.Infra.Data.AppContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume_V2.Application.Services.Impelementations
{
    public class SocialMediaService : ISocialMedia
    {
        #region Constructor
        private readonly AppDbContext _context;
        public SocialMediaService(AppDbContext context)
        {
            _context = context;
        }
        #endregion
        public async Task<List<SocialMediaViewModel>> GetAllSocialMedia()
        {
            List<SocialMediaViewModel> socialMedias = await _context.SocialMedias.OrderBy(s => s.Order)
                .Select(s => new SocialMediaViewModel()
                {
                    Icon = s.Icon,
                    Order = s.Order,
                    Id = s.Id,
                    Link = s.Link
                }).ToListAsync();
            return socialMedias;
        }
    }
}
