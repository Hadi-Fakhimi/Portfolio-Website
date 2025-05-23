using Resume_V2.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume_V2.Application.Services.Interfaces
{
    public interface IPageVisit
    {
        Task<int> IncrementVisitCount(string pageUrl);
        Task<int> GetVisitCount(string pageUrl);
        Task RecordVisitAsync();
        Task<List<int>> GetDailyVisitsAsync();
        Task<List<int>> GetWeeklyVisitsAsync();
        Task<List<int>> GetMonthlyVisitsAsync();

    }
}
