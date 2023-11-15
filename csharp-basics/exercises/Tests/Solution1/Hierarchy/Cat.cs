using System;

namespace Hierarchy
{
    public class Cat : Feline
    {
        public string CatBreed { get; }

        public Cat(string animalName, double animalWeight, string livingRegion, string breed)
            : base(animalName, animalWeight, livingRegion)
        {
            CatBreed = breed;
        }

        public override void MakeSound()
        {
            Console.WriteLine("> Meeeooow");
        }

        public override bool WillEatFood(Food food)
        {
            return true;
        }

        public override string ToString()
        {
            return $"Cat {AnimalName} {AnimalWeight.ToString("0.00")} {LivingRegion} {CatBreed}";
        }
    }
}