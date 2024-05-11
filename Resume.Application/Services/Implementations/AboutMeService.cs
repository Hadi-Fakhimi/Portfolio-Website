using Microsoft.EntityFrameworkCore;
using Resume.Application.Services.Interfaces;
using Resume.Domain.Models;
using Resume.Domain.ViewModels.AboutMe;
using Resume.Domain.ViewModels.Information;
using Resume.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.Services.Implementations
{
    public class AboutMeService:IAboutMeService
    {
        #region Constructor

        private readonly AppDbContext _dbContext;

        public AboutMeService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        #endregion
        public async Task<bool> CreateOrEditAboutMe(CreateOrEditAboutMeViewModel aboutMe)
        {
            if (aboutMe.Id == 0)
            {
                var newAboutMe = new AboutMe()
                {
                    paragraf1 = aboutMe.paragraf1,
                    paragraf2 = aboutMe.paragraf2,
                    title = aboutMe.title
                };

                await _dbContext.AboutMes.AddAsync(newAboutMe);
                await _dbContext.SaveChangesAsync();
                return true;


            }

            var currentAboutMe = await GetAboutMeViewModelById(aboutMe.Id);

            if(currentAboutMe == null)
            {
                return false;
            }

            currentAboutMe.title = aboutMe.title;
            currentAboutMe.paragraf1 = aboutMe.paragraf1;
            currentAboutMe.paragraf2 = aboutMe.paragraf2;

            _dbContext.AboutMes.Update(currentAboutMe);

            await _dbContext.SaveChangesAsync();

            return true;
        }
        public async Task<bool> DeleteAboutMe(long id)
        {
            AboutMe aboutMe =await GetAboutMeViewModelById(id);

            if(aboutMe == null)
            {
                return false;
            }
            _dbContext.AboutMes.Remove(aboutMe);
            await _dbContext.SaveChangesAsync();
            return true;


        }
        public async Task<CreateOrEditAboutMeViewModel> FillCreateOrEditAboutMeViewModel(long id)
        {
            if(id == 0)
            {
                return new CreateOrEditAboutMeViewModel() {Id   = 0 };
            }


            AboutMe aboutMe = await GetAboutMeViewModelById(id);

            if (aboutMe == null)
            {
                return new CreateOrEditAboutMeViewModel() { Id = 0 };

            }

            return new CreateOrEditAboutMeViewModel()
            {
                Id = aboutMe.Id,
                title = aboutMe.title,
                paragraf1 = aboutMe.paragraf1,
                paragraf2 = aboutMe.paragraf2
            };


        }
        public async Task<AboutMe> GetAboutMeViewModelById(long id)
        {
            return await _dbContext.AboutMes.FirstOrDefaultAsync(a => a.Id == id);
        }
        public async Task<AboutMeViewModel> GetAllAboutMeForIndex()
        {
            AboutMeViewModel aboutMes = await _dbContext.AboutMes
            .Select(a => new AboutMeViewModel()
            {
                Id = a.Id,
                paragraf1 = a.paragraf1,
                paragraf2 = a.paragraf2,
                title = a.title
            }).FirstOrDefaultAsync();


            return aboutMes;
        }
    }
}
