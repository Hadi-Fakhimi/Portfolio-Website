using Microsoft.Extensions.DependencyInjection;
using Resume_V2.Application.Convertors;
using Resume_V2.Application.Extensions;
using Resume_V2.Application.Senders.Implementations;
using Resume_V2.Application.Senders.Interface;
using Resume_V2.Application.Services.Impelementations;
using Resume_V2.Application.Services.Interfaces;

namespace Resume_V2.Infra.Ioc
{
    public class DependencyContainers
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<ISocialMedia,SocialMediaService>();
            services.AddScoped<IAboutMe,AboutMeService>();
            services.AddScoped<IItem,ItemService>();
            services.AddScoped<ISkill,SkillService>();
            services.AddScoped<IPortfolio,PortfolioService>();
            services.AddScoped<IPortfolioCategory,PortfolioCategoryService>();
            services.AddScoped<IThingIDo,ThingIDoService>();
            services.AddScoped<ICustomerFeedback,CustomerFeedbackService>();
            services.AddScoped<ICustomerLogo,CustomerLogoService>();
            services.AddScoped<IEducation,EducationService>();
            services.AddScoped<IExperience,ExperienceService>();
            services.AddScoped<IMessage,MessageService>();
            services.AddScoped<IInformation,InformationService>();
            services.AddScoped<IBlog,BlogService>();
            services.AddScoped<PanelLayoutScope>();
            services.AddScoped<IBlogPage,BlogPageService>();
            services.AddScoped<IPortfolioPage,PortfolioPageService>();
            services.AddScoped<IUser,UserService>();
            services.AddScoped<IEmailService, EmailService>();
            services.AddScoped<IViewRenderService, RenderViewToString>();
            services.AddScoped<IPageVisit,PageVisitService>();


		}
    }
}
