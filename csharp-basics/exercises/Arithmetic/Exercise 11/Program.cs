using System.Diagnostics.Metrics;
using System.Numerics;
using System.Xml.Linq;
using System;

namespace Exercise_11
{
    public class Program
    {
        public static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;
            if (number == 2)
                return true;

            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
        public static int SumOfDigits(int number)
        {
            int sum = 0;
            number = Math.Abs(number);
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }

        public static string FindNumberType(int number)
        {
            int sumDigits = SumOfDigits(number);
            if (sumDigits == 0)
                return "Neither";

            if (number % sumDigits == 0)
            {
                if (IsPrime(number / sumDigits))
                    return "M";
                else
                    return "H";
            }
            else
            {
                return "Neither";
            }
        }

        public static void Main()
        {
            Console.Write("Enter a number: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                string result = FindNumberType(number);
                Console.WriteLine($"Result: {result}");
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}