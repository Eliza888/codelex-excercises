using System.Reflection;
using System;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First integer:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Second integer:");
            int num2 = int.Parse(Console.ReadLine());

            bool result = (num1 == 15 || num2 == 15 || num1 + num2 == 15 || Math.Abs(num1 - num2) == 15);

            Console.WriteLine(result);
        }
    }
}


    