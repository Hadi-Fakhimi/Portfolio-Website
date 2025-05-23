using Microsoft.EntityFrameworkCore;
using Resume_V2.Application.DTOs;
using Resume_V2.Application.Services.Interfaces;
using Resume_V2.Infra.Data.AppContext;

namespace Resume_V2.Application.Services.Impelementations
{
    public class AboutMeService : IAboutMe
    {
        #region Constructor

        private readonly AppDbContext _context;
        public AboutMeService(AppDbContext context)
        {
            _context = context;
        }

        #endregion
        public async Task<AboutMeViewModel> GetAllAboutMeViewModel()
        {
            AboutMeViewModel about = await _context.AboutMes.OrderBy(a => a.Id)
                .Select(a => new AboutMeViewModel()
                {
                    Id = a.Id,
                    AvatarImage = a.AvatarImage,
                    Name = a.Name,
                    Description = a.Description,
                    Title = a.Title
                }).FirstOrDefaultAsync();


            return about;
        }

    }
}
