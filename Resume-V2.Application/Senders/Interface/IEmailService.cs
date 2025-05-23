using Resume_V2.Domain.Models.SiteSetting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume_V2.Application.Senders.Interface
{
    public interface IEmailService
    {
        Task<EmailSetting> GetDefaultEmail();
        Task<bool> SendEmail(string to, string subject, string body);
    }
}
