using System;
using System.Collections.Generic;
using System.Linq;

namespace UniqueValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var values = new List<string> { "Hi", "Meow", "Hello", "Meow", "Hi!", "Meow", "Hi", "Bye" };

            var nonRepeatingValues = values.GroupBy(value => value)
                                                       .Where(group => group.Count() == 1)
                                                       .Select(group => group.Key)
                                                       .ToList();

            foreach (var value in nonRepeatingValues)
            {
                Console.WriteLine(value);
            }
        }
    }
}