using Microsoft.EntityFrameworkCore;
using Resume.Application.Services.Interfaces;
using Resume.Domain.Models;
using Resume.Domain.ViewModels.ThingIDo;
using Resume.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.Services.Implementations
{
    public class ThingIDoService : IThingIDoService
    {
        #region Constructor
        private readonly AppDbContext _dbContext;
        public ThingIDoService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> CreateOrEditThingIDo(CreateOrEditThingIDoViewModel thingIDo)
        {
            if(thingIDo.Id == 0)
            {
                var newThingIDo = new ThingIDo() 
                {
                    
                    Col_lg = thingIDo.Col_lg,
                    description = thingIDo.description,
                    Icon = thingIDo.Icon,
                    Order = thingIDo.Order,
                    Title = thingIDo.Title
                };
                await _dbContext.ThingIDos.AddAsync(newThingIDo);
                await _dbContext.SaveChangesAsync();

                return true;
            }
            ThingIDo currentThingIDo = await GetThingIDoById(thingIDo.Id);

            if (currentThingIDo == null)
            {
                return false;
            }
            currentThingIDo.Order = thingIDo.Order;
            currentThingIDo.Title = thingIDo.Title;
            currentThingIDo.Icon = thingIDo.Icon;
            currentThingIDo.Col_lg = thingIDo.Col_lg;
            currentThingIDo.description = thingIDo.description;

            _dbContext.ThingIDos.Update(currentThingIDo);
            await _dbContext.SaveChangesAsync();

            return true;

        }

        public async Task<bool> DeleteThingIDo(long id)
        {
            ThingIDo thingIDo = await GetThingIDoById(id);
            if (thingIDo == null)
            {
                return false;
            }

            _dbContext.ThingIDos.Remove(thingIDo);

            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<CreateOrEditThingIDoViewModel> FillCreateOrEditThingIDoViewModel(long id)
        {
            if (id == 0) return new CreateOrEditThingIDoViewModel() { Id = 0 };

            ThingIDo thingIDo = await GetThingIDoById(id);

            if (thingIDo == null) return new CreateOrEditThingIDoViewModel() { Id = 0 };

            return new CreateOrEditThingIDoViewModel()
            {
                Id = thingIDo.Id,
                Col_lg = thingIDo.Col_lg,
                description = thingIDo.description,
                Icon = thingIDo.Icon,
                Order = thingIDo.Order,
                Title = thingIDo.Title
            };
        }

        #endregion
        public async Task<List<ThingIDoListViewModel>> GetAllThingIDoForIndex()
        {
            List<ThingIDoListViewModel> thingIDos = await _dbContext.ThingIDos.OrderBy(t=>t.Order)
                .Select(t=> new ThingIDoListViewModel()
                {
                    Id = t.Id,
                    Icon = t.Icon,
                    Title = t.Title,
                    Order = t.Order,
                    description = t.description,
                    Col_lg = t.Col_lg
                }).ToListAsync();

            return thingIDos;
        }

        public async Task<ThingIDo> GetThingIDoById(long id)
        {
            return await _dbContext.ThingIDos.SingleOrDefaultAsync(t => t.Id == id);
        }
    }
}
