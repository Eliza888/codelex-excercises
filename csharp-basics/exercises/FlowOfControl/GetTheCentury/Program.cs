using System;

namespace GetTheCentury
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetCentury(1756)); 
            Console.WriteLine(GetCentury(1555)); 
            Console.WriteLine(GetCentury(1000)); 
            Console.WriteLine(GetCentury(1001));
            Console.WriteLine(GetCentury(2005));
        }

        public static string GetCentury(int year)
        {
            int century = (year - 1) / 100 + 1;

            switch (century)
            {
                case 11:
                case 12:
                case 13:
                    return $"{century}th century";
                default:
                    int lastDigit = century % 10;
                    switch (lastDigit)
                    {
                        case 1:
                            return $"{century}st century";
                        case 2:
                            return $"{century}nd century";
                        case 3:
                            return $"{century}rd century";
                        default:
                            return $"{century}th century";
                    }
            }
        }
    }
}