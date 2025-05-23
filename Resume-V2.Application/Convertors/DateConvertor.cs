using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume_V2.Application.Convertors
{
    public static class DateConvertor
    {
        private static string[] persianMonths =
        {
            "فروردین", "اردیبهشت", "خرداد", "تیر", "مرداد",
            "شهریور", "مهر", "آبان",
            "آذر", "دی", "بهمن", "اسفند"
        };
        public static string ToShamsiMonth(this DateTime value)
        {
            PersianCalendar persianCalendar = new PersianCalendar();
            int monthNumber = persianCalendar.GetMonth(value);
            int monthNum = Convert.ToInt32(monthNumber);
            return persianMonths[monthNum - 1];
        }

        public static string ToShamsiYear(this DateTime value)
        {
            PersianCalendar persianCalendar = new PersianCalendar();
            return  Convert.ToString(persianCalendar.GetYear(value));
        }
        public static string ToShamsiDay(this DateTime value)
        {
            PersianCalendar persianCalendar = new PersianCalendar();
            return Convert.ToString(persianCalendar.GetDayOfMonth(value));
        }
    }


}
