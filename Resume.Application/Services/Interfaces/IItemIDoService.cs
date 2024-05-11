using Resume.Domain.Models;
using Resume.Domain.ViewModels.ItemIDo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.Services.Interfaces
{
    public interface IItemIDoService
    {
        Task<ItemIDo> GetItemIDoById(long id);
        Task<List<ItemIDoViewModel>> GetAllItemIDo();
        Task<CreateOrEditItemIDoViewModel> FillCreateOrEditItemIDoViewModel(long id);
        Task<bool> CreateOrEditItemIDoViewModel(CreateOrEditItemIDoViewModel itemIDo);
        Task<bool> DeleteItemIDo(long id);

    }
}
