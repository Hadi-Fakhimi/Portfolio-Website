using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Resume_V2.Application.Extensions
{
    public static class UserExtensions
    {
        public static string GetUserName(this ClaimsPrincipal claimsPrincipal)
        {
            var identifier = claimsPrincipal.Claims.SingleOrDefault(s => s.Type == ClaimTypes.Name);
            if (identifier == null) return "";
            return identifier.Value;
        }

    }
}
