using System;
using System.Collections.Generic;

namespace DecryptNumber
{
    internal class Program
    {
        // look at the keyboard.
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
                long sum = 0;
                foreach (char c in crypted)
                {
                    int value = GetCharacterValue(c);
                    sum = sum * 10 + value;
                }

                Console.WriteLine($"Crypted: {crypted}, Decrypted number: {sum}");
            }
        }

        static int GetCharacterValue(char c)
        {
            switch (c)
            {
                case '!': return 1;
                case '@': return 2;
                case '#': return 3;
                case '$': return 4;
                case '%': return 5;
                case '^': return 6;
                case '&': return 7;
                case '*': return 8;
                case '(': return 9;
                case ')': return 0;
                default: return 0;
            }
        }
    }
}