using Microsoft.EntityFrameworkCore;
using Resume.Application.Services.Interfaces;
using Resume.Domain.Models;
using Resume.Domain.ViewModels.Information;
using Resume.Infra.Data.Context;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Resume.Application.Services.Implementations
{
    public class InformationService : IInformationService
    {
        #region Constructor
        private readonly AppDbContext _dbContext;

        public InformationService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        #endregion

        public async Task<bool> CreateOrEditInformationViewModel(CreateOrEditInformationViewModel information)
        {
            if (information.Id == 0)
            {
                var newInformation = new Information ()
                {
                    Avatar = information.Avatar,
                    Address = information.Address,
                    Email =  information.Email,
                    DateOfBirth = information.DateOfBirth,
                    InstagramAddress = information.InstagramAddress,
                    Job = information.Job,
                    MapSrc = information.MapSrc,
                    Name = information.Name,
                    Phone= information.Phone,
                    ResumeFile = information.ResumeFile,
                    TelegramAddress = information.TelegramAddress
                };
                await _dbContext.Informations.AddAsync(newInformation);
                await _dbContext.SaveChangesAsync();

                return true;
            }

            var currentInformation = await GetInformationViewModelById(information.Id);

            if(currentInformation == null)
            {
                return false;
            }
            currentInformation.Avatar = information.Avatar;
            currentInformation.Address = information.Address;
            currentInformation.Email = information.Email;
            currentInformation.DateOfBirth = information.DateOfBirth;
            currentInformation.InstagramAddress = information.InstagramAddress;
            currentInformation.Job = information.Job;
            currentInformation.MapSrc = information.MapSrc;
            currentInformation.Name = information.Name;
            currentInformation.Phone = information.Phone;
            currentInformation.ResumeFile = information.ResumeFile;
            currentInformation.TelegramAddress = information.TelegramAddress;


            _dbContext.Informations.Update(currentInformation);

            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteInformation(long id)
        {
            var information = await GetInformationViewModelById(id);
            if(information == null)
            {
                return false;
            }
            _dbContext.Informations.Remove(information);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<CreateOrEditInformationViewModel> FillCreateOrEditInformationViewModel(long id)
        {
            if(id == 0)
            {
                return new CreateOrEditInformationViewModel() { Id = 0 };
            }

            Information information = await GetInformationViewModelById(id);
            if(information == null)
            {
                return new CreateOrEditInformationViewModel() { Id = 0 };
            }

            return new CreateOrEditInformationViewModel()
            {
                Id = information.Id,
                Avatar = information.Avatar,
                Address = information.Address,
                Email = information.Email,
                DateOfBirth = information.DateOfBirth,
                InstagramAddress = information.InstagramAddress,
                Job = information.Job,
                MapSrc = information.MapSrc,
                Name = information.Name,
                Phone = information.Phone,
                ResumeFile = information.ResumeFile,
                TelegramAddress = information.TelegramAddress

            };
        }


        public async Task<InformationViewModel> GetInformation()
        {

            InformationViewModel information = await _dbContext.Informations.
                Select(i => new InformationViewModel()
                {
                    Avatar= i.Avatar,
                    DateOfBirth = i.DateOfBirth,
                    Address= i.Address,
                    Email= i.Email,
                    Id= i.Id,
                    Job = i.Job,
                    Name= i.Name,
                    Phone= i.Phone,
                    ResumeFile = i.ResumeFile,
                    MapSrc= i.MapSrc,
                    InstagramAddress= i.InstagramAddress,
                    TelegramAddress= i.TelegramAddress
                    
                
                }).FirstOrDefaultAsync();

            if(information == null)
            {
                return new InformationViewModel();
            }
            return information;
        }

        public async Task<Information> GetInformationViewModelById(long id)
        {
            return await _dbContext.Informations.SingleOrDefaultAsync(i => i.Id == id);
        }
    }
        
}
