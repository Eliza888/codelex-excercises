using System;
using System.Globalization;

namespace Hierarchy
{
    public class Zebra : Mammal
    {
        public Zebra(string animalName, double animalWeight, string livingRegion)
            : base(animalName, "Zebra", animalWeight, livingRegion)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("> Zeeebra");
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