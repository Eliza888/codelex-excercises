using System;
using System.Collections.Generic;

namespace Exercise_10
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> stringSet = new HashSet<string>();

            stringSet.Add("Apple");
            stringSet.Add("Banana");
            stringSet.Add("Cherry");
            stringSet.Add("Watermelon");
            stringSet.Add("Strawberry");

            Console.WriteLine("Items in the HashSet:");
            foreach (var item in stringSet)
            {
                Console.WriteLine(item);
            }

            stringSet.Clear();

            Console.WriteLine("\nItems after clearing the HashSet:");
            foreach (var item in stringSet)
            {
                Console.WriteLine(item);
            }

            stringSet.Add("Apple");
            bool isAdded = stringSet.Add("Apple");

            Console.WriteLine("Is 'Apple' not a duplicate? " + isAdded);
        }
    }
}