using Microsoft.EntityFrameworkCore;
using Resume.Application.Services.Interfaces;
using Resume.Domain.Models;
using Resume.Domain.ViewModels.SocialMedia;
using Resume.Infra.Data.Context;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resume.Application.Services.Implementations
{
    public class SocialMediaService : ISocialMediaService
    {
        #region Constructor
        private readonly AppDbContext _dbContext;
        public SocialMediaService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        #endregion
        public async Task<bool> CreateOrEditeSocialMedia(CreateOrEditSocialMediaViewModel socialMedia)
        {
            if (socialMedia.Id == 0)
            {
                var newSocialMedia = new SocialMedia()
                {
                    Icon = socialMedia.Icon,
                    Order = socialMedia.Order,
                    Link = socialMedia.Link
                };

                await _dbContext.SocialMedias.AddAsync(newSocialMedia);

                await _dbContext.SaveChangesAsync();
                return true;
            }

            var currentSocialMedia = await GetSocialMediaById(socialMedia.Id);

            if (currentSocialMedia == null)
            {
                return false;
            }

            currentSocialMedia.Icon = socialMedia.Icon;
            currentSocialMedia.Order = socialMedia.Order;
            currentSocialMedia.Link = socialMedia.Link;

            _dbContext.SocialMedias.Update(currentSocialMedia);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteSocialMedia(long id)
        {
            SocialMedia socialMedia = await GetSocialMediaById(id);
            if (socialMedia == null)
            {
                return false;
            }

            _dbContext.SocialMedias.Remove(socialMedia);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<CreateOrEditSocialMediaViewModel> FillCreateOrEditSocialMediaViewModel(long id)
        {
            if (id == 0)
            {
                return new CreateOrEditSocialMediaViewModel() { Id = 0 };

            }

            SocialMedia socialMedia = await GetSocialMediaById(id);

            if (socialMedia == null)
            {
                return new CreateOrEditSocialMediaViewModel() { Id = 0 };

            }

            return new CreateOrEditSocialMediaViewModel()
            {
                Icon = socialMedia.Icon,
                Order = socialMedia.Order,
                Link = socialMedia.Link,
                Id = socialMedia.Id
            };
        }

        public async Task<List<SocialMediaViewModel>> GetAllSocialMedias()
        {
            List<SocialMediaViewModel> socialMedias = await _dbContext.SocialMedias.OrderBy(s => s.Order)
                .Select(s => new SocialMediaViewModel()
                {
                    Id = s.Id,
                    Order = s.Order,
                    Icon = s.Icon,
                    Link = s.Link
                }).ToListAsync();

            return socialMedias;
        }

        public async Task<SocialMedia> GetSocialMediaById(long id)
        {
            return await _dbContext.SocialMedias.FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
