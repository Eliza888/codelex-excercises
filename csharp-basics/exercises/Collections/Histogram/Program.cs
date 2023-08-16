using System;
using System.Collections.Generic;
using System.IO;

namespace Histogram
{
    class Program
    {
        private const string Path = "../../../midtermscores.txt";

        private static void Main(string[] args)
        {
            try
            {
                var readText = File.ReadAllText(Path).Split(" ");
                Dictionary<int, int> scoreCounts = new Dictionary<int, int>();

                for (int i = 0; i <= 100; i += 10)
                {
                    scoreCounts[i] = 0;
                }

                foreach (var s in readText)
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

                // Print the histogram with score counts
                for (int i = 0; i <= 100; i += 10)
                {
                    int upperBound = i + 9;
                    Console.Write($"{i:D2}-{upperBound:D2}: ");

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
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}