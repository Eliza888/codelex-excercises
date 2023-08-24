using System;

namespace Hierarchy
{
    abstract class Mammal : Animal
    {
        public string LivingRegion { get; }

        public Mammal(string animalName, string animalType, double animalWeight, string livingRegion)
            : base(animalName, animalType, animalWeight)
        {
            LivingRegion = livingRegion;
        }
    }
}