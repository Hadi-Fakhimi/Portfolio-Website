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
    public class ItemService : IItem
    {
        #region Constructor
        private readonly AppDbContext _context;
        public ItemService(AppDbContext context)
        {
            _context = context;
        }

        #endregion
        public async Task<List<ItemViewModel>> GetAllItem()
        {
            List<ItemViewModel> items = await _context.Items.OrderBy(i => i.Id)
                .Select(i => new ItemViewModel()
                {
                   
                    Count = i.Count,
                    ItemName = i.ItemName

                }).ToListAsync();

            return items;

        }
    }
}
