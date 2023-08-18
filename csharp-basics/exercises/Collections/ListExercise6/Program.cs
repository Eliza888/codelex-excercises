using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Reflection;
using System.Xml.Linq;

namespace ListExercise6
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

            Console.WriteLine(string.Join(",", colors));

            colors.RemoveAt(2);

            Console.WriteLine("Removed third element from the list:");
            Console.WriteLine(string.Join(",", colors));
        }
    }
}