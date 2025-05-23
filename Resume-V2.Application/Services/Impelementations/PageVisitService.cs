using Microsoft.EntityFrameworkCore;
using Resume_V2.Application.Services.Interfaces;
using Resume_V2.Domain.Models;
using Resume_V2.Infra.Data.AppContext;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume_V2.Application.Services.Impelementations
{
    public class PageVisitService : IPageVisit
    {
        #region Constructor
        private readonly AppDbContext _context;
        public PageVisitService(AppDbContext context)
        {
            _context = context;
        }
        #endregion

        public async Task<int> IncrementVisitCount(string pageUrl)
        {
            var pageVisit = await _context.PageVisits.FirstOrDefaultAsync(p => p.PageUrl == pageUrl);

            if (pageVisit == null)
            {
                pageVisit = new Domain.Models.PageVisit()
                {
                    VisitCount = 0,
                    PageUrl = pageUrl
                };
                _context.PageVisits.Add(pageVisit);
            }
            else
            {
                pageVisit.VisitCount += 1;
            }

            await _context.SaveChangesAsync();
            return pageVisit.VisitCount;
        }
        public async Task<int> GetVisitCount(string pageUrl)
        {
            var pageVisit = await _context.PageVisits
                              .AsNoTracking()
                              .FirstOrDefaultAsync(p => p.PageUrl == pageUrl);

            return pageVisit?.VisitCount ?? 0;

        }



        public async Task RecordVisitAsync()
        {
            var today = DateTime.Today;

            var visitRecord = await _context.RecordHomePageVisits.FirstOrDefaultAsync(v => v.Date == today);

            if (visitRecord != null)
            {
                visitRecord.VisitCount++;
            }
            else
            {
                _context.RecordHomePageVisits.Add(new RecordHomePageVisit
                {
                    Date = today,
                    VisitCount = 1
                });
            }

            await _context.SaveChangesAsync();
        }


        public async Task<List<int>> GetDailyVisitsAsync()
        {
            var sevenDaysAgo = DateTime.Today.AddDays(-6);

            var result = await _context.RecordHomePageVisits
                .Where(v => v.Date >= sevenDaysAgo) 
                .GroupBy(v => v.Date.Date)
                .OrderBy(g => g.Key) 
                .Select(g => g.Sum(v => v.VisitCount)) 
                .ToListAsync();

            return result;
        }

        public async Task<List<int>> GetWeeklyVisitsAsync()
        {
            var fourWeeksAgo = DateTime.Today.AddDays(-28);

            var visits = await _context.RecordHomePageVisits
                .Where(v => v.Date >= fourWeeksAgo)
                .ToListAsync();

            var weeklyVisits = visits
                .GroupBy(v => CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(
                    v.Date, CalendarWeekRule.FirstDay, DayOfWeek.Sunday))
                .Select(g => g.Sum(v => v.VisitCount))
                .ToList();

            return weeklyVisits;
        }


        public async Task<List<int>> GetMonthlyVisitsAsync()
        {
            var twelveMonthsAgo = DateTime.Today.AddMonths(-12);

            return await _context.RecordHomePageVisits
                .Where(v => v.Date >= twelveMonthsAgo)
                .GroupBy(v => v.Date.Month)
                .Select(g => g.Sum(v => v.VisitCount))
                .ToListAsync();
        }



    }
}
