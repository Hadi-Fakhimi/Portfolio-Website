using Microsoft.EntityFrameworkCore;
using Resume.Domain.Models;
using Resume.Domain.Models.SiteSetting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Infra.Data.Context
{
    public class AppDbContext : DbContext
    {
        #region Constructor


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        #endregion

        #region DbSets

        public DbSet<User> Users { get; set; }
        public DbSet<ThingIDo> ThingIDos { get; set; }
        public DbSet<CustomerFeedback> CustomerFeedbacks { get; set; }
        public DbSet<CustomerLogo> CustomerLogos { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<PortfolioCategory> PortfolioCategories { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Information> Informations { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<AboutMe> AboutMes { get; set; }
        public DbSet<ItemIDo> ItemIDos { get; set; }
        public DbSet<EmailSetting> EmailSettings { get; set; }








        #endregion

        #region on model creating

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
            #region Seed Data
            var date = DateTime.Now;


            modelBuilder.Entity<EmailSetting>().HasData(new EmailSetting()
            {
                CreateDate = date,
                DisplayName = "Resume-HadiFakhimi",
                EnableSSl = true,
                From = "",
                Id = 1,
                IsDelete = false,
                IsDefault = true,
                Password = "",
                Port = 587,
                SMTP = "smtp.gmail.com"

            });

            modelBuilder.Entity<User>().HasData(new User()
            {
                Id = 1,
                CreateDate = date,
                Password = "5F-AD-AB-BF-3E-52-4E-D4-8C-22-9E-96-88-1D-50-71",
                Email = "HadiFakhimi13@gmail.com",
                FirstName = "هادی",
                LastName = "فخیمی",
                EmailActivationCode = "123456789",
                IsDelete = false,
                IsAdmin = true,
                IsEmailConfirmed = true

            });

            #endregion


            base.OnModelCreating(modelBuilder);
        }

        #endregion


    }
}
