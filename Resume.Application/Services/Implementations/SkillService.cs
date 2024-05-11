using Microsoft.EntityFrameworkCore;
using Resume.Application.Services.Interfaces;
using Resume.Domain.Models;
using Resume.Domain.ViewModels.Skill;
using Resume.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.Services.Implementations
{
    public class SkillService : ISkillService
    {
        #region Constructor
        private readonly AppDbContext _dbContext;
        public SkillService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

       #endregion
        public async Task<List<SkillViewModel>> GetSkillForIndexPage()
        {
            List<SkillViewModel> skill = await _dbContext.Skills.OrderBy(s => s.Order)
                .Select(s => new SkillViewModel() 
                {
                    Id = s.Id,
                    Percent = s.Percent,
                    Order = s.Order,
                    Title = s.Title

                }).ToListAsync();


            return skill;
        }
        public async Task<bool> CreateOrEditSkill(CreateOrEditSkillViewModel skill)
        {
            if(skill.Id == 0)
            {
                var newSkill = new Skill()
                {
                    Order = skill.Order,
                    Percent= skill.Percent,
                    Title = skill.Title
                };

                await _dbContext.Skills.AddAsync(newSkill);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            Skill currentSkill = await GetSkillById(skill.Id);

            if(currentSkill != null)
            {
                return false;
            }
            currentSkill.Percent = skill.Percent;
            currentSkill.Order = skill.Order;
            currentSkill.Title = skill.Title;

            _dbContext.Skills.Update(currentSkill);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteSkill(long id)
        {
            Skill skill = await GetSkillById(id);

            if(skill == null)
            {
                return false;
            }
            _dbContext.Skills.Remove(skill);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<CreateOrEditSkillViewModel> FillCreateOrEditSkillViewModel(long id)
        {
            if(id == 0)
            {
                return new CreateOrEditSkillViewModel() { Id = 0 };
            }

            Skill skill = await GetSkillById(id);

            if (skill == null)
            {
                return new CreateOrEditSkillViewModel() { Id = 0 };


            }
            return new CreateOrEditSkillViewModel()
            {
                Id = skill.Id,
                Order = skill.Order,
                Title = skill.Title,
                Percent = skill.Percent
            };

        }

        public async Task<Skill> GetSkillById(long id)
        {
            return await _dbContext.Skills.SingleOrDefaultAsync(s => s.Id == id);

        }
    }
}
