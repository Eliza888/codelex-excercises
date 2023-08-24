using System;
using System.Collections.Generic;

namespace ListExercise3
{
    class Program
    {
        static void Main(string[] args)
        {

            var colors = new List<string>();
            colors.Add("Red");
            colors.Add("Green");
            colors.Add("Orange");
            colors.Add("White");
            colors.Add("Black");

            colors.Insert(0, "Purple");
            colors.Insert(2, "Yellow");

            Console.WriteLine("List with new colors:");
            Console.WriteLine(string.Join(",", colors));
        }
    }
}