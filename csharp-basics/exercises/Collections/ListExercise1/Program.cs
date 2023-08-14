using System;
using System.Collections.Generic;

namespace ListExercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            List<string> colorsList = new List<string>();

            colorsList.Add("Red");
            colorsList.Add("Green");
            colorsList.Add("Blue");
            colorsList.Add("Yellow");
            colorsList.Add("Purple");

            Console.WriteLine("Colors in the list:");
            foreach (var color in colorsList)
            {
                Console.WriteLine(color);
            }
        }
    }
}