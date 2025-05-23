using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume_V2.Application.Convertors
{
    public static class NameConvertor
    {
        public static string FullName(string name, string family)
        {
            return name + " " + family;
        }
    }
}
