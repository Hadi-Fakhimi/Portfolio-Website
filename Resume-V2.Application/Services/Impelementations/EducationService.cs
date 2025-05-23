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
    public class EducationService : IEducation
    {
        #region Constructor
        private readonly AppDbContext _context;
        public EducationService(AppDbContext context)
        {
            _context = context;
        }
        #endregion
        public async Task<List<EducationViewModel>> GetAllEducation()
        {
            List<EducationViewModel> educations = await _context.Educations.OrderBy(e => e.Order)
                .Select(e => new EducationViewModel() 
                {
                    Description = e.Description,
                    Order = e.Order,
                    EndDate = e.EndDate,
                    StartDate = e.StartDate,
                    Title = e.Title
                }).ToListAsync();

            return educations;
        }
    }
}
