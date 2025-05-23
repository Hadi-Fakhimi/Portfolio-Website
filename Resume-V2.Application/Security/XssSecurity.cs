using Ganss.Xss;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume_V2.Application.Security
{
    public static class XssSecurity
    {
        public static string SanitizeText(this string text)
        {
            var htmlSanitizer = new HtmlSanitizer();
            htmlSanitizer.KeepChildNodes = true;
            htmlSanitizer.AllowDataAttributes = true;

            return htmlSanitizer.Sanitize(text);

        }
    }
}
