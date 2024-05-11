using Microsoft.EntityFrameworkCore;
using Resume.Application.Services.Interfaces;
using Resume.Domain.Models;
using Resume.Domain.ViewModels.ItemIDo;
using Resume.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.Services.Implementations
{
    public class ItemIDoService : IItemIDoService
    {
        #region Constructor

        private readonly AppDbContext _dbContext;

        public ItemIDoService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        #endregion

        public async Task<bool> CreateOrEditItemIDoViewModel(CreateOrEditItemIDoViewModel itemIDo)
        {
           if(itemIDo.Id == 0)
            {
                ItemIDo newItemIDo = new ItemIDo() 
                {
                    Name = itemIDo.Name,
                    Order = itemIDo.Order,
                    Number = itemIDo.Number
                };

                await _dbContext.ItemIDos.AddAsync(newItemIDo);

                await _dbContext.SaveChangesAsync();
                return true;
            }

            ItemIDo currentItemIDo = await GetItemIDoById(itemIDo.Id);

            if(currentItemIDo == null)
            {
               return false;
            }

            currentItemIDo.Name = itemIDo.Name;
            currentItemIDo.Order = itemIDo.Order;
            currentItemIDo.Number = itemIDo.Number;


            _dbContext.ItemIDos.Update(currentItemIDo);
            await _dbContext.SaveChangesAsync();
            return true;

        }
        public async Task<bool> DeleteItemIDo(long id)
        {
            var itemIDo = await GetItemIDoById(id);
            if(itemIDo == null)
            {
                return false;
            }
            _dbContext.ItemIDos.Remove(itemIDo);
            await _dbContext.SaveChangesAsync();
            return true;
        }
        public async Task<CreateOrEditItemIDoViewModel> FillCreateOrEditItemIDoViewModel(long id)
        {
            if (id == 0)
            {
                return new CreateOrEditItemIDoViewModel() { Id = 0 };
            }
            ItemIDo itemIDo = await GetItemIDoById(id);

            if (itemIDo == null)
            {
                return new CreateOrEditItemIDoViewModel() {Id =0 };
            }
            return new CreateOrEditItemIDoViewModel() 
            { 
                Id = itemIDo.Id,
                Name = itemIDo.Name,
                Number = itemIDo.Number,
                Order = itemIDo.Order
            };
        }
        public async Task<List<ItemIDoViewModel>> GetAllItemIDo()
        {
            List<ItemIDoViewModel> items = await _dbContext.ItemIDos.OrderBy(i => i.Order)
                .Select(i => new ItemIDoViewModel()
                {
                    Id = i.Id,
                    Name = i.Name,
                    Number = i.Number,
                    Order = i.Order
                }).ToListAsync();

            return items;
        }
        public async Task<ItemIDo> GetItemIDoById(long id)
        {
            return await _dbContext.ItemIDos.SingleOrDefaultAsync(i => i.Id == id);
        }
    }
}
