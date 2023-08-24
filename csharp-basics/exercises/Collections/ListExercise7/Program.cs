using System;
using System.Collections.Generic;

namespace ListExercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            var colors = new List<string>
            {
                "Red",
                "Green",
                "Orange",
                "White",
                "Black"
            };

            bool containsWhite = colors.Contains("White");

            Console.WriteLine($"Does list contain the color 'White'? {containsWhite}");
        }
    }
}