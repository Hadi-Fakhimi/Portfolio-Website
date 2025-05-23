using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Resume_V2.Application.DTOs;
using Resume_V2.Application.Services.Interfaces;
using Resume_V2.Infra.Data.AppContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume_V2.Application.Services.Impelementations
{
    public class InformationService : IInformation
    {
        #region Constractor
        private readonly AppDbContext _context;
        public InformationService(AppDbContext context)
        {
            _context = context;
        }
        #endregion


        public async Task<InformationViewModel> GetAllInformation()
        {
            InformationViewModel information = await _context.Informations
                .Select(i => new InformationViewModel()
                {
                    Address = i.Address,
                    DateOfBirth = i.DateOfBirth,
                    Email = i.Email,
                    InstagramAddress = i.InstagramAddress,
                    Job = i.Job,
                    MapSrc = i.MapSrc,
                    Name = i.Name,
                    Phone = i.Phone,
                    ResumeFile = i.ResumeFile,
                    TelegramAddress = i.TelegramAddress
                }).FirstOrDefaultAsync();

            return information;
        }
    }
}
