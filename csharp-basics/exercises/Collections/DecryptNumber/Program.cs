using System;
using System.Collections.Generic;
using System.Linq;

namespace DecryptNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cryptedNumbers = new List<string>
            {
                "())(",
                "*$(#&",
                "!!!!!!!!!!",
                "$*^&@!",
                "!)(^&(#@",
                "!)(#&%(*@#%"
            };

            foreach (var crypted in cryptedNumbers)
            {
                long sum = crypted.Aggregate(0L, (currentSum, c) => currentSum * 10 + GetCharacterValue(c));
                Console.WriteLine($"Crypted: {crypted}, Decrypted number: {sum}");
            }
        }

        static int GetCharacterValue(char c)
        {
            return c switch
            {
                '!' => 1,
                '@' => 2,
                '#' => 3,
                '$' => 4,
                '%' => 5,
                '^' => 6,
                '&' => 7,
                '*' => 8,
                '(' => 9,
                ')' => 0,
                _ => 0
            };
        }
    }
}