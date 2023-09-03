using System;

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
            return $"{GetType().Name}[{base.ToString()}]";
        }
    }
}