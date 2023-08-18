using System;
using System.IO;
using System.Text.RegularExpressions;

namespace SimpleWordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "../../../lear.txt";
            string[] lines = File.ReadAllLines(filePath);

            int lineCount = lines.Length;
            int wordCount = CountWords(lines);
            int charCount = CountCharacters(lines);

            Console.WriteLine($"Lines = {lineCount}");
            Console.WriteLine($"Words = {wordCount}");
            Console.WriteLine($"Chars = {charCount}");
        }

        static int CountWords(string[] lines)
        {
            int count = 0;
            foreach (string line in lines)
            {
                string[] words = Regex.Split(line, @"\W+");
                foreach (string word in words)
                {
                    if (!string.IsNullOrWhiteSpace(word))
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        static int CountCharacters(string[] lines)
        {
            int count = 0;
            foreach (string line in lines)
            {
                count += line.Length;
            }
            return count;
        }
    }
}