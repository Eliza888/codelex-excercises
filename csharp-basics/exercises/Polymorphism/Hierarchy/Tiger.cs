using Hierarchy;
using System;

namespace Hierarchy
{
    class Tiger : Feline
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
            return $"Tiger[{base.ToString()}]";
        }
    }
}