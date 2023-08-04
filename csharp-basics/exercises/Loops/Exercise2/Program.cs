using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            
            Console.WriteLine("Input number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Input the base number : ");
            int baseNumber = Convert.ToInt32(Console.ReadLine());

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