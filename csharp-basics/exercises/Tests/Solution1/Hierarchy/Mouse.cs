using System;
using System.Globalization;

namespace Hierarchy
{
    public class Mouse : Mammal
    {
        public Mouse(string animalName, double animalWeight, string livingRegion)
            : base(animalName, "Mouse", animalWeight, livingRegion)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("> Squeak");
        }

        public override bool WillEatFood(Food food)
        {
            return food is Vegetable;
        }

        public override string ToString()
        {
            return $"{GetType().Name} {AnimalName} {AnimalWeight.ToString("0.00", CultureInfo.InvariantCulture)} {LivingRegion}";
        }
    }
}