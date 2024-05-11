using Microsoft.EntityFrameworkCore;
using Resume.Application.Services.Interfaces;
using Resume.Domain.Models.SiteSetting;
using Resume.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using XAct;

namespace Resume.Application.Services.Implementations
{
    public class EmailService:IEmailService
    {
        private readonly AppDbContext _dbContext;

        public EmailService(AppDbContext dbContext)
        {
            _dbContext = dbContext;   
        }

        public async Task<EmailSetting> GetDefaultEmail()
        {
            return await _dbContext.EmailSettings.FirstOrDefaultAsync(e => !e.IsDelete && e.IsDefault);
        }

        public async Task<bool> SendEmail(string to, string subject, string body)
        {
            try
            {
                var defaultSiteEmail = await GetDefaultEmail();

                MailMessage mailMessage= new MailMessage();
                SmtpClient smtpServer = new SmtpClient(defaultSiteEmail.SMTP);

                mailMessage.From = new MailAddress(defaultSiteEmail.From,defaultSiteEmail.DisplayName);
                mailMessage.To.Add(to);
                mailMessage.Subject = subject;
                mailMessage.Body = body;
                mailMessage.IsBodyHtml = true;

                if(defaultSiteEmail.Port != 0)
                {
                    smtpServer.Port = defaultSiteEmail.Port;
                    smtpServer.EnableSsl = defaultSiteEmail.EnableSSl;
                }

                smtpServer.Credentials = new NetworkCredential(defaultSiteEmail.From, defaultSiteEmail.Password);
                smtpServer.Send(mailMessage);

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
