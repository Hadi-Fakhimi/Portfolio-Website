using Microsoft.EntityFrameworkCore;
using Resume_V2.Application.DTOs;
using Resume_V2.Application.Services.Interfaces;
using Resume_V2.Domain.Models;
using Resume_V2.Infra.Data.AppContext;

namespace Resume_V2.Application.Services.Impelementations
{
    public class ThingIDoService : IThingIDo
    {
        #region Constructor
        private readonly AppDbContext _context;
        public ThingIDoService(AppDbContext context)
        {
            _context = context;
        }

        #endregion
        public async Task<List<ThingIDoViewModel>> GetAllThingIDo()
        {
            List<ThingIDoViewModel> thingIDo = await _context.ThingIDos.OrderBy(t => t.Order)
                .Select(t => new ThingIDoViewModel()
                {
                    Order = t.Order,
                    description = t.description,
                    Icon = t.Icon,
                    Title = t.Title,
                    Id = t.Id


                }).ToListAsync();


            return thingIDo;
        }

        public async Task<ThingIDo> GetThingIDoById(long id)
        {
            return await _context.ThingIDos.SingleOrDefaultAsync(t => t.Id == id);

        }



        public async Task<bool> CreateOrEditThingIDo(CreateOrEditThingIDo thingIDo)
        {
            if (thingIDo.Id == 0)
            {
                var newThingIDo = new ThingIDo()
                {
                    description = thingIDo.description,
                    Icon = thingIDo.Icon,
                    Title = thingIDo.Title,
                    Order = thingIDo.Order,

                };

                await _context.ThingIDos.AddAsync(newThingIDo);
                await _context.SaveChangesAsync();

                return true;
            }
            ThingIDo currentThingIDo = await GetThingIDoById(thingIDo.Id);

            if (currentThingIDo == null)
            {
                return false;
            }
            currentThingIDo.description = thingIDo.description;
            currentThingIDo.Order = thingIDo.Order;
            currentThingIDo.Title = thingIDo.Title;
            currentThingIDo.Icon = thingIDo.Icon;
            _context.ThingIDos.Update(currentThingIDo);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<CreateOrEditThingIDo> FillCreateOrEditThingIDo(long id)
        {
            if (id == 0)
            {
                return new CreateOrEditThingIDo(){ Id = 0 };
            }
            var thingIDo = await GetThingIDoById(id);
            if (thingIDo == null) 
            {
                return new CreateOrEditThingIDo(){Id = 0};
            }
            return new CreateOrEditThingIDo()
            {
                Id = thingIDo.Id,
                description = thingIDo.description,
                Order = thingIDo.Order,
                Icon = thingIDo.Icon,
                Title = thingIDo.Title
            };
        }
    }
}
