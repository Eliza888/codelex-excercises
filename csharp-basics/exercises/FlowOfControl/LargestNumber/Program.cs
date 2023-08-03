using System;

namespace LargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the 1st number: ");
            var input1 = Console.ReadLine();

            Console.WriteLine("Input the 2nd number: ");
            var input2 = Console.ReadLine();

            Console.WriteLine("Input the 3rd number: ");
            var input3 = Console.ReadLine();

            int number1 = int.Parse(input1);
            int number2 = int.Parse(input2);
            int number3 = int.Parse(input3);

            int largestNumber = Math.Max(number1, Math.Max(number2, number3));

            Console.WriteLine("The largest number is: " + largestNumber);
        }
    }
}