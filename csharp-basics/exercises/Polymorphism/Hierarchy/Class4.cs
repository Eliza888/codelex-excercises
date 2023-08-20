using System;
using System;

namespace Hierarchy
{
    class Cat : Feline
    {
        public string Breed { get; }

        public Cat(string animalName, double animalWeight, string livingRegion, string breed)
            : base(animalName, animalWeight, livingRegion)
        {
            Breed = breed;
        }

        public override void MakeSound()
        {
            Console.WriteLine("> Meowwww");
        }

        public override bool WillEatFood(Food food)
        {
            return true;
        }

        public override string ToString()
        {
            return $"Cat[{AnimalName}, {Breed}, {AnimalWeight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}