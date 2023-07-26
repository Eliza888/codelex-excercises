using System;

namespace MoreVariablesAndPrinting
{
    class Program
    {
        public static double HeightInInches { get; private set; }
        public static double WeightInPounds { get; private set; }

        static void Main(string[] args)
        {
           
            string Name = "Zed A. Shaw";
            int Age = 35;
            int Height = 74;  
            int Weight = 180; 
            string Eyes = "Blue";
            string Teeth = "White";
            string Hair = "Brown";

            double HeightInCentimeters = Height * 2.54;
            double WeightInKilos = Math.Round(Weight * 0.453592, 2);

            Console.WriteLine("Let's talk about " + Name + ".");
            Console.WriteLine("He's " + HeightInCentimeters + " centimeters tall.");
            Console.WriteLine("He's " + WeightInKilos + " kilograms heavy.");
            Console.WriteLine("Actually, that's not too heavy.");
            Console.WriteLine("He's got " + Eyes + " eyes and " + Hair + " hair.");
            Console.WriteLine("His teeth are usually " + Teeth + " depending on the coffee.");
            Console.WriteLine("If I add " + Age + ", " + HeightInCentimeters + " cm, and " + WeightInKilos
                               + " kg, I get " + (Age + HeightInCentimeters + WeightInKilos) + ".");

            Console.ReadKey();
        }
    }
}