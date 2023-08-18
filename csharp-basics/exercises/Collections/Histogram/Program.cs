using System;
using System.Collections.Generic;
using System.IO;

namespace Histogram
{
    class Program
    {
        private const string Path = "../../../midtermscores.txt";

        static void Main(string[] args)
        {
            string[] readText = File.ReadAllText(Path).Split(' ');
            Dictionary<int, int> scoreCounts = new Dictionary<int, int>();

            for (int i = 0; i <= 100; i += 10)
            {
                scoreCounts[i] = 0;
            }

            foreach (string s in readText)
            {
                if (int.TryParse(s, out int score))
                {
                    if (score >= 0 && score <= 100)
                    {
                        int rangeIndex = score / 10 * 10;
                        scoreCounts[rangeIndex]++;
                    }
                }
            }

            for (int i = 0; i <= 100; i += 10)
            {
                int upperBound = i + 9;
                Console.Write(i.ToString("00") + "-" + upperBound.ToString("00") + ": ");

                if (scoreCounts.ContainsKey(i))
                {
                    int count = scoreCounts[i];
                    for (int j = 0; j < count; j++)
                    {
                        Console.Write("*");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}