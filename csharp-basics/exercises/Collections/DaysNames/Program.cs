using System;
using System.Linq;

namespace DayNamesQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = {
                "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"
            };

            var dayNamesQuery = from day in daysOfWeek
                                select day;

            Console.WriteLine("Names of days:");
            foreach (var dayName in dayNamesQuery)
            {
                Console.WriteLine(dayName);
            }
        }
    }
}