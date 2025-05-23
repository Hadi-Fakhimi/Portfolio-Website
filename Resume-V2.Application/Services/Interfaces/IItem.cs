using Resume_V2.Application.DTOs;
using Resume_V2.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume_V2.Application.Services.Interfaces
{
    public interface IItem
    {
        public Task<List<ItemViewModel>> GetAllItem();
    }
}
