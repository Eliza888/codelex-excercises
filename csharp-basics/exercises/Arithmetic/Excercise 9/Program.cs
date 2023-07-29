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


            double bmi = (weightInPounds * 703) / Math.Pow(heightInInches, 2);


            Console.WriteLine($"Your BMI is: {bmi}");


            string weightStatus = bmi switch
            {
                var val when val < 18.5 => "Underweight",
                var val when val >= 18.5 && val <= 25 => "Optimal Weight",
                _ => "Overweight",
            };

            Console.WriteLine($"Weight Status: {weightStatus}");
        }
    }
}