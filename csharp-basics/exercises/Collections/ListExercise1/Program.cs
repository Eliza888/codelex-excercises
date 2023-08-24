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

            Console.WriteLine("Colors have been added to the list.");
        }
    }
}