using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;

namespace NumbersFromRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var numbers = new List<int>();
            while (numbers.Count() < 10)
            {
                numbers.Add(random.Next(1, 100));
            }

            var filteredNumbers = numbers.Where(num => num > 30 && num < 100).ToList();

            Console.WriteLine("Filtered Numbers:");
            foreach (var num in filteredNumbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}