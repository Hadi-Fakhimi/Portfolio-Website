using Microsoft.Extensions.DependencyInjection;
using Resume.Application.Services.Implementations;
using Resume.Application.Services.Interfaces;

namespace Resume.Infra.Ioc
{
    public class DependencyContainers
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IThingIDoService,ThingIDoService>();
            services.AddScoped<ICustomerFeedbackService,CustomerFeedbackService>();
            services.AddScoped<ICustomerLogoService,CustomerLogoService>();
            services.AddScoped<IEducationSerivce, EducationService>();
            services.AddScoped<IExperienceService, ExperienceService>();
            services.AddScoped<ISkillService, SkillService>();
            services.AddScoped<IPortfolioService, PortfolioService>();
            services.AddScoped<IPortfolioCategoryService, PortfolioCategoryService>();
            services.AddScoped<ISocialMediaService,SocialMediaService>();
            services.AddScoped<IInformationService,InformationService>();
            services.AddScoped<IMessageService,MessageService>();
            services.AddScoped<IAboutMeService,AboutMeService>();
            services.AddScoped<IItemIDoService,ItemIDoService>();
            services.AddScoped<IUserService,UserService>();
            services.AddScoped<IEmailService,EmailService>();

        }
    }
}
