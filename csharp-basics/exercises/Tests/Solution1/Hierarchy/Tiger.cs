using System;
using System.Globalization;

namespace Hierarchy
{
    public class Tiger : Feline
    {
        public Tiger(string animalName, double animalWeight, string livingRegion)
            : base(animalName, animalWeight, livingRegion)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("> ROAAR!!!");
        }

        public override bool WillEatFood(Food food)
        {
            return food is Meat;
        }

        public override string ToString()
        {
            return $"{GetType().Name} {AnimalName} {AnimalWeight.ToString("0.00", CultureInfo.InvariantCulture)} {LivingRegion}";
        }
    }
}