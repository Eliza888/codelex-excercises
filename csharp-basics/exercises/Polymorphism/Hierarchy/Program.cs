using System;
using System.Collections.Generic;
using System.Globalization;

namespace Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> usedAnimals = new List<string>();

            Dictionary<int, string> animalChoices = new Dictionary<int, string>
            {
                { 1, "Cat Gray 1.1 Home Persian" },
                { 2, "Tiger Typcho 167.7 Asia" },
                { 3, "Mouse Squeaky 0.1 Field" },
                { 4, "Zebra Stripes 400.5 Savannah" }
            };

            Dictionary<int, string> foodChoices = new Dictionary<int, string>
            {
                { 1, "Meat" },
                { 2, "Vegetable" }
            };

            Console.WriteLine("Choose an animal:");
            foreach (var choice in animalChoices)
            {
                Console.WriteLine($"{choice.Key} for {choice.Value}");
            }
            Console.WriteLine("5 to End");

            while (true)
            {
                int selection;
                if (!int.TryParse(Console.ReadLine(), out selection))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                if (selection == 5)
                {
                    break;
                }

                string animalInfo = animalChoices[selection];
                string[] animalInfoParts = animalInfo.Split();
                string animalType = animalInfoParts[0];
                string animalName = animalInfoParts[1];
                double animalWeight = double.Parse(animalInfoParts[2], CultureInfo.InvariantCulture);
                string animalLivingRegion = animalInfoParts[3];
                string catBreed = animalInfoParts.Length > 4 ? animalInfoParts[4] : null;

                Animal animal = CreateAnimal(animalType, animalName, animalWeight, animalLivingRegion, catBreed);
                if (animal != null)
                {
                    animal.MakeSound();
                }

                if (animal != null)
                {
                    Console.WriteLine("Choose food:");
                    foreach (var choice in foodChoices)
                    {
                        Console.WriteLine($"{choice.Key} for {choice.Value}");
                    }

                    int foodSelection;
                    if (!int.TryParse(Console.ReadLine(), out foodSelection))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        continue;
                    }

                    string foodType = foodChoices[foodSelection];

                    Food food = CreateFood(foodType, 1);

                    if (food != null && animal is Tiger tiger && !tiger.WillEatFood(food))
                    {
                        Console.WriteLine($"{tiger.GetType().Name}s are not eating that type of food!");
                    }
                    else if (food != null && animal is Mouse mouse && !mouse.WillEatFood(food))
                    {
                        Console.WriteLine($"{mouse.GetType().Name}s are not eating that type of food!");
                    }
                    else if (food != null && animal is Zebra zebra && !zebra.WillEatFood(food))
                    {
                        Console.WriteLine($"{zebra.GetType().Name}s are not eating that type of food!");
                    }
                    else
                    {
                        animal.Eat(food);
                    }

                    Console.WriteLine(animal);
                    usedAnimals.Add(animal.ToString());
                }
            }

            Console.WriteLine("Animals used:");
            foreach (var usedAnimal in usedAnimals)
            {
                Console.WriteLine(usedAnimal);
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
                case "Zebra":
                    return new Zebra(animalName, animalWeight, animalLivingRegion);
                case "Mouse":
                    return new Mouse(animalName, animalWeight, animalLivingRegion);
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
                default:
                    return null;
            }
        }
    }
}