using System;
using System.Globalization;

namespace Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = null;

            string[] animalInfo = Console.ReadLine().Split();
            string animalType = animalInfo[0];
            string animalName = animalInfo[1];
            double animalWeight = double.Parse(animalInfo[2], CultureInfo.InvariantCulture);
            string animalLivingRegion = animalInfo[3];
            string catBreed = animalInfo.Length > 4 ? animalInfo[4] : null;

            animal = CreateAnimal(animalType, animalName, animalWeight, animalLivingRegion, catBreed);
            if (animal != null)
            {
                animal.MakeSound();
            }

            if (animal is Tiger tiger)
            {
                string[] foodInfo = Console.ReadLine().Split();
                string foodType = foodInfo[0];
                int quantity = int.Parse(foodInfo[1]);

                Food food = CreateFood(foodType, quantity);

                if (food != null && !tiger.WillEatFood(food))
                {
                    Console.WriteLine($"{tiger.GetType().Name}s are not eating that type of food!");
                }
            }
            else if (animal != null)
            {
                string[] foodInfo = Console.ReadLine().Split();
                string foodType = foodInfo[0];
                int quantity = int.Parse(foodInfo[1]);

                Food food = CreateFood(foodType, quantity);

                if (food != null)
                {
                    animal.Eat(food);
                    Console.WriteLine(animal);
                }
            }
        }

        static Animal CreateAnimal(string animalType, string animalName, double animalWeight, string animalLivingRegion, string catBreed)
        {
            switch (animalType)
            {
                case "Cat":
                    return new Cat(animalName, animalWeight, animalLivingRegion, catBreed);
                case "Tiger":
                    return new Tiger(animalName, animalWeight, animalLivingRegion);
                // Add other animal types here...
                default:
                    return null;
            }
        }

        static Food CreateFood(string foodType, int quantity)
        {
            switch (foodType)
            {
                case "Vegetable":
                    return new Vegetable(quantity);
                case "Meat":
                    return new Meat(quantity);
                // Add other food types here...
                default:
                    return null;
            }
        }
    }
}