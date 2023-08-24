using System;

namespace Exercise_5
{
    internal class Program
    {
        static int CalculateSumOfSquares(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                int number = num % 10;
                sum += number * number;
                num /= 10;
            }
            return sum;
        }

        static bool IsHappy(int num)
        {
            HashSet<int> visited = new HashSet<int>();

            while (num != 1 && !visited.Contains(num))
            {
                visited.Add(num);
                num = CalculateSumOfSquares(num);
            }

            return num == 1;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            bool isHappy = IsHappy(num);

            if (isHappy)
            {
                Console.WriteLine($"{num} is a happy number.");
            }
            else
            {
                Console.WriteLine($"{num} is not a happy number.");
            }
        }
    }
}