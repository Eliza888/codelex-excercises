using System.Collections.Generic;
using System;

namespace ListExercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> fruits = new List<string>();

            fruits.Add("Apple");
            fruits.Add("Banana");
            fruits.Add("Orange");
            fruits.Add("Grapes");
            fruits.Add("Mango");
            fruits.Add("Pineapple");
            fruits.Add("Strawberry");
            fruits.Add("Cherry");
            fruits.Add("Watermelon");
            fruits.Add("Kiwi");

            fruits.Insert(4, "Pear");

            int lastIndex = fruits.Count - 1;
            fruits[lastIndex] = "Peach";

            fruits.Sort();

            bool containsFoobar = fruits.Contains("Foobar");
            Console.WriteLine($"Does the list contain 'Foobar'? {containsFoobar}");

            Console.WriteLine("Fruits list:");
            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
        }
    }
}