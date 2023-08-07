using System;
using System.IO;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;

            Console.WriteLine("Input number of terms : ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the base number : ");
            int baseNumber = int.Parse(Console.ReadLine());

            int result = 1;
            for (i = 0; i < n; i++)
            {
                result *= baseNumber;
            }

            Console.WriteLine($"Result: {result}");
            Console.ReadKey();
        }
    }
}