using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_14
{
    internal class Date
    {
        public static string WeekdayInDutch(int year, int month, int day)
        {
            DateTime date = new DateTime(year, month, day);
            CultureInfo dutchCulture = new CultureInfo("nl-NL");
            return date.ToString("dddd", dutchCulture);
        }
    }
}