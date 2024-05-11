using Microsoft.EntityFrameworkCore;
using Resume.Application.Services.Interfaces;
using Resume.Domain.Models;
using Resume.Domain.ViewModels.Experience;
using Resume.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.Services.Implementations
{
    public class ExperienceService : IExperienceService
    {

        #region Cunstructor

        private readonly AppDbContext _dbContext;

        public ExperienceService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }



        #endregion
        public async Task<List<ExperienceViewModel>> GetExperienceForIndexPage()
        {
            List<ExperienceViewModel> experience = await _dbContext.Experiences.OrderBy(e => e.Order)
                .Select(e => new ExperienceViewModel() 
                {
                    Id = e.Id,
                    Order = e.Order,
                    Description = e.Description,
                    EndDate = e.EndDate,
                    StartDate = e.StartDate,
                    Title = e.Title,

                }).ToListAsync();

            return experience;
        }

        public async Task<bool> CreateOrEditExperience(CreateOrEditExperienceViewModel experience)
        {
            if(experience.Id == 0)
            {
                var newExperience = new Experience() 
                {
                    Order = experience.Order,
                    Description = experience.Description,
                    EndDate = experience.EndDate,
                    StartDate = experience.StartDate,
                    Title = experience.Title
                };

                await _dbContext.Experiences.AddAsync(newExperience);
                await _dbContext.SaveChangesAsync();

                return true;

            }

            Experience currentExperience = await GetExperienceById(experience.Id);

            if(currentExperience == null)
            {
                return false;
            }

            currentExperience.Order = experience.Order;
            currentExperience.Title = experience.Title;
            currentExperience.StartDate = experience.StartDate;
            currentExperience.EndDate = experience.EndDate;
            currentExperience.Description = experience.Description;

            _dbContext.Experiences.Update(currentExperience);

            await _dbContext.SaveChangesAsync();

            return true;


        }

        public async Task<bool> DeleteExperience(long id)
        {
            Experience experience = await GetExperienceById(id);

            if(experience == null)
            {
                return false;
            }

            _dbContext.Experiences.Remove(experience);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<CreateOrEditExperienceViewModel> FillCreateOrEditExperienceViewModel(long id)
        {
            if (id == 0)
            {
                return new CreateOrEditExperienceViewModel() { Id = 0};
            }

            Experience experience = await GetExperienceById(id);
            if(experience == null)
            {
                return new CreateOrEditExperienceViewModel() { Id = 0};
            }

            return new CreateOrEditExperienceViewModel()
            {
                Id = experience.Id,
                Order = experience.Order,
                Description = experience.Description,
                EndDate = experience.EndDate,
                StartDate = experience.StartDate,
                Title = experience.Title

            };
        }

        public async Task<Experience> GetExperienceById(long id)
        {
            return (await _dbContext.Experiences.FirstOrDefaultAsync(e => e.Id == id));
        }
    }
}
