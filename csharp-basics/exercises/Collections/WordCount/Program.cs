using System;
using System.IO;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "../../../lear.txt";

            int lineCount = 0;
            int wordCount = 0;
            int charCount = 0;

            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    lineCount++;

                    charCount += line.Length;

                    string[] words = line.Split(new[] { ' ', ' ', ' ', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string word in words)
                    {
                        bool isWord = true;
                        foreach (char c in word)
                        {
                            if (!char.IsLetterOrDigit(c))
                            {
                                isWord = false;
                                break;
                            }
                        }

                        if (isWord)
                        {
                            wordCount++;
                        }
                    }
                }
            }

            Console.WriteLine($"Lines = {lineCount}");
            Console.WriteLine($"Words = {wordCount}");
            Console.WriteLine($"Chars = {charCount}");
        }
    }
}