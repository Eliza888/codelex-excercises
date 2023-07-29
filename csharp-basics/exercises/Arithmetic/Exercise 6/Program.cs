using Exercise_6;
using System.ComponentModel;
using System.Net.NetworkInformation;
using System;

namespace Exercise_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int start = 1;
            const int end = 110;
            const int numbersPerLine = 11;

            for (int i = start; i <= end; i++)
            {
                string output = "";

                if (i % 3 == 0)
                    output += "Coza";
                if (i % 5 == 0)
                    output += "Loza";
                if (i % 7 == 0)
                    output += "Woza";

                if (output == "")
                    output = i.ToString();

                Console.Write(output + " ");

                if (i % numbersPerLine == 0)
                    Console.WriteLine();
            }
        }
    }
}




