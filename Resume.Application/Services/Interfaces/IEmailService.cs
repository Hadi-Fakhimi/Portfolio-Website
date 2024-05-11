using Resume.Domain.Models.SiteSetting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.Services.Interfaces
{
    public interface IEmailService
    {
        Task<EmailSetting> GetDefaultEmail();
        Task<bool> SendEmail(string to , string subject , string body );
    }
}
