using PositiveNegativeNumber;
using System;
using System.Diagnostics.Metrics;
using System.Runtime.Intrinsics.X86;
using System.Threading.Channels;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PositiveNegativeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number.");
            var input = Console.ReadKey();
            int number = int.Parse(input.KeyChar.ToString());

            if (number > 0)
            {
                Console.WriteLine("Number is positive");
            }
            else if (number < 0)
            {
                Console.WriteLine("Number is negative");
            }
            else
            {
                Console.WriteLine("Number is zero");
            }
        }
    }
}
