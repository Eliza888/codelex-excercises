using System;
using System.Globalization;

namespace Hierarchy
{
    public abstract class Animal
    {
        public string AnimalName { get; }
        public string AnimalType { get; }
        public double AnimalWeight { get; protected set; }
        public int FoodEaten { get; protected set; }

        public Animal(string animalName, string animalType, double animalWeight)
        {
            AnimalName = animalName;
            AnimalType = animalType;
            AnimalWeight = animalWeight;
            FoodEaten = 0;
        }

        public void Eat(Food food)
        {
            FoodEaten += food.Quantity;
        }

        public abstract void MakeSound();

        public abstract bool WillEatFood(Food food);

        public override string ToString()
        {
            return $"{AnimalType}[{AnimalName}, {AnimalWeight.ToString("0.00", CultureInfo.InvariantCulture)}, {FoodEaten}]";
        }
    }
}