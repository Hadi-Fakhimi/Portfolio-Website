using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Domain.Models.SiteSetting
{
    public class EmailSetting
    {
        public long Id { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsDelete { get; set; }  
        public string From { get; set; }
        public string Password { get; set; }
        public string SMTP { get; set; }
        public bool EnableSSl { get; set; }
        public string DisplayName { get; set; }
        public int Port { get; set; }
        public bool IsDefault { get; set; }

    }
}
