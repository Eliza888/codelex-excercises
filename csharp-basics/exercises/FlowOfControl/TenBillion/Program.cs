using System;

namespace TenBillion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input an integer number less than ten billion:");

            if (long.TryParse(Console.ReadLine(), out long number) && number >= -9999999999L && number < 10000000000L)
            {
                number = Math.Abs(number); 
                int digitCount = number == 0 ? 1 : (int)Math.Floor(Math.Log10(number)) + 1;
                Console.WriteLine($"The number has {digitCount} digit(s).");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer number between ten billion.");
            }
        }
    }
}