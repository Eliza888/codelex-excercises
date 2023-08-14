using System.Linq;
using System;

namespace ReplaceSubstring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var words = new[] { "near", "speak", "tonight", "weapon", "customer", "deal", "lawyer" };

            var replacedWords = words.Select(word => word.Replace("ea", "*")).ToArray();

            foreach (var replacedWord in replacedWords)
            {
                Console.WriteLine(replacedWord);
            }
        }
    }
}