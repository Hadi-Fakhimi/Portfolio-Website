using Microsoft.EntityFrameworkCore;
using Resume.Application.Services.Interfaces;
using Resume.Domain.Models;
using Resume.Domain.ViewModels.Education;
using Resume.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.Services.Implementations
{

    public class EducationService : IEducationSerivce
    {
        #region Constructor
        private readonly AppDbContext _dbContext;
        public EducationService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        #endregion
        public async Task<bool> CreateOrEditeEducation(CreateOrEditEducationViewModel education)
        {
            if(education.Id == 0)
            {
                var newEducation = new Education()
                {
                    Title   = education.Title,
                    Description = education.Description,
                    EndDate = education.EndDate,
                    Order= education.Order,
                    StartDate = education.StartDate
                };

                await _dbContext.Educations.AddAsync(newEducation);

                await _dbContext.SaveChangesAsync();

                return true;


            }
            Education currentEducation = await GetEducationById(education.Id);

            if(currentEducation == null)
            {
                return false;
            }

            currentEducation.StartDate = education.StartDate;
            currentEducation.EndDate = education.EndDate;
            currentEducation.Description = education.Description;
            currentEducation.Order = education.Order;
            currentEducation.Title = education.Title;


            _dbContext.Educations.Update(currentEducation);

            await _dbContext.SaveChangesAsync();

            return true;

        }

        public async Task<bool> DeleteEducation(long id)
        {
            Education education = await GetEducationById(id);

            if(education == null)
            {
                return false;
            }
            _dbContext.Educations.Remove(education);

            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<CreateOrEditEducationViewModel> FillCreateOrEditEducationViewModel(long id)
        {
            if(id == 0)
            {
                return new CreateOrEditEducationViewModel() { Id = 0 };
            }

            Education education = await GetEducationById(id);

            if (education == null)
            {
                return new CreateOrEditEducationViewModel() { Id = 0 };
            }

            return new CreateOrEditEducationViewModel()
            {
                Id = education.Id,
                Description = education.Description,
                EndDate = education.EndDate,
                Order = education.Order,
                StartDate = education.StartDate,
                Title = education.Title
            };

        }

        public async Task<Education> GetEducationById(long id)
        {
            return await _dbContext.Educations.FirstOrDefaultAsync(e => e.Id == id);
        }


        public async Task<List<EducationViewModel>> GetEducationForIndexPage()
        {
            List<EducationViewModel> education = await _dbContext.Educations.OrderBy(e => e.Order)
                .Select(e => new EducationViewModel() 
                {
                    Id = e.Id,
                    Title = e.Title,
                    StartDate=e.StartDate,
                    EndDate=e.EndDate,
                    Description = e.Description,
                    Order = e.Order

                }).ToListAsync();

            return education;
        }
    }
}
