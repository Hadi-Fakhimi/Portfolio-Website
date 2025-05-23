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
    public class ExperienceService : IExperience
    {
        #region Constructor
        private readonly AppDbContext _context;
        public ExperienceService(AppDbContext context)
        {
            _context = context;
        }
        #endregion
        public async Task<List<ExperienceViewModel>> GetAllExperience()
        {
            List<ExperienceViewModel> experiences = await _context.Experiences.OrderBy(e =>e.Order)
                .Select(e => new ExperienceViewModel() 
                {
                    Order = e.Order,
                    Description = e.Description,
                    EndDate = e.EndDate,
                    StartDate = e.StartDate,
                    Title = e.Title
                }).ToListAsync();
            return experiences;
        }
    }
}
