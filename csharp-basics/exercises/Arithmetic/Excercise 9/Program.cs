using System.Buffers.Text;
using System.Diagnostics.Metrics;
using System;

namespace Excercise_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Body Mass Index (BMI) Calculator");

            Console.Write("Enter your weight in pounds: ");
            double weightInPounds = double.Parse(Console.ReadLine());

            Console.Write("Enter your height in inches: ");
            double heightInInches = double.Parse(Console.ReadLine());

            double bmi = (weightInPounds * 703) / (heightInInches * heightInInches);
         
            Console.WriteLine($"Your BMI is: {bmi}");

            if (bmi < 18.5)
            {
                Console.WriteLine("Weight Status: Underweight");
            }
            else if (bmi >= 18.5 && bmi <= 25)
            {
                Console.WriteLine("Weight Status: Optimal Weight");
            }
            else
            {
                Console.WriteLine("Weight Status: Overweight");
            }
        }
    }
}