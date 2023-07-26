using System;

namespace MoreVariablesAndPrinting
{
    class Program
    {
        public static double HeightInInches { get; private set; }
        public static double WeightInPounds { get; private set; }

        static void Main(string[] args)
        {
           
            string name = "Zed A. Shaw";
            int age = 35;
            int height = 74;  
            int weight = 180; 
            string eyes = "Blue";
            string teeth = "White";
            string hair = "Brown";

            double heightInCentimeters = height * 2.54;
            double weightInKilos = Math.Round(weight * 0.453592, 2);

            Console.WriteLine("Let's talk about " + name + ".");
            Console.WriteLine("He's " + heightInCentimeters + " centimeters tall.");
            Console.WriteLine("He's " + weightInKilos + " kilograms heavy.");
            Console.WriteLine("Actually, that's not too heavy.");
            Console.WriteLine("He's got " + eyes + " eyes and " + hair + " hair.");
            Console.WriteLine("His teeth are usually " + teeth + " depending on the coffee.");
            Console.WriteLine("If I add " + age + ", " + heightInCentimeters + " cm, and " + weightInKilos
                               + " kg, I get " + (age + heightInCentimeters + weightInKilos) + ".");

            Console.ReadKey();
        }
    }
}