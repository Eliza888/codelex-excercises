using System.Collections.Generic;
using System;

namespace Exercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            string[] array = { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla" };

            List<string> list = new List<string>(array);
            Console.WriteLine("Using List:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            HashSet<string> hashSet = new HashSet<string>(array);
            Console.WriteLine("Using HashSet:");
            foreach (var item in hashSet)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Dictionary<string, string> dictionary = new Dictionary<string, string>
            {
                { "Audi", "Germany" },
                { "BMW", "Germany" },
                { "Honda", "Japan" },
                { "Mercedes", "Germany" },
                { "VolksWagen", "Germany" },
                { "Tesla", "USA" }
            };

            Console.WriteLine("Using Dictionary:");
            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}