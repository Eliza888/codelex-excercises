using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            Dictionary<int, string> animalChoices = new Dictionary<int, string>
            {
                { 1, "Cat Gray 1.1 Home Persian" },
                { 2, "Tiger Typcho 167.7 Asia" },
                { 3, "Mouse Squeaky 0.1 Field" },
                { 4, "Zebra Stripes 400.5 Savannah" }
            };

            Console.WriteLine("Choose an animal:");
            foreach (var choice in animalChoices)
            {
                Console.WriteLine($"{choice.Key} for {choice.Value}");
            }
            Console.WriteLine("5 to End");

            while (true)
            {
                int selection = int.Parse(Console.ReadLine());

                if (selection == 5)
                {
                    break;
                }

                string animalInfo = animalChoices[selection];
                string[] animalInfoParts = animalInfo.Split();
                string animalType = animalInfoParts[0];  // Fix: Animal type is the first element
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
                 
                }
            }

            if (animals.Any())
            {
                Console.WriteLine(string.Join(", ", animals));
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