using Microsoft.EntityFrameworkCore;
using Resume_V2.Application.DTOs;
using Resume_V2.Application.Services.Interfaces;
using Resume_V2.Domain.Models;
using Resume_V2.Infra.Data.AppContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume_V2.Application.Services.Impelementations
{
    public class SkillService : ISkill
    {
        #region Constructor
        private readonly AppDbContext _context;
        public SkillService(AppDbContext context)
        {
            _context = context;
        }

        #endregion
        public async Task<List<SkillViewModel>> GetAllSkill()
        {
            List<SkillViewModel> skills = await _context.Skills.OrderBy(s =>s.Id)
                .Select(s => new SkillViewModel()
                {
                    AbilityName = s.AbilityName,
                    Icon = s.Icon,
                    Percent = s.Percent
                }).ToListAsync();

            return skills;
        }
    }
}
