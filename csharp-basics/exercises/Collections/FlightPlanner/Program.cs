using System;
using System.Collections.Generic;
using System.IO;

namespace FlightPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "../../../flights.txt";
            Console.WriteLine("File Path: " + filePath);

            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found.");
                return;
            }

            Dictionary<string, List<string>> flightData = ReadFlightData(filePath);

            Console.WriteLine("What would you like to do:");
            Console.WriteLine("To display list of the cities press 1");
            Console.WriteLine("To exit program press #");

            while (true)
            {
                Console.Write("> ");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    DisplayCities(flightData);
                }
                else if (input == "#")
                {
                    Console.WriteLine("Exiting program.");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
            }
        }

        static Dictionary<string, List<string>> ReadFlightData(string filePath)
        {
            Dictionary<string, List<string>> flights = new Dictionary<string, List<string>>();

            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] cities = line.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

                if (cities.Length == 2)
                {
                    if (!flights.ContainsKey(cities[0]))
                    {
                        flights[cities[0]] = new List<string>();
                    }
                    flights[cities[0]].Add(cities[1]);
                }
            }

            return flights;
        }

        static void DisplayCities(Dictionary<string, List<string>> flightData)
        {
            Console.WriteLine("Cities:");
            foreach (string city in flightData.Keys)
            {
                Console.WriteLine(city);
            }

            Console.WriteLine("Select a city from which you would like to start:");
            string startCity = Console.ReadLine();

            if (flightData.ContainsKey(startCity))
            {
                PlanRoundTrip(flightData, startCity);
            }
            else
            {
                Console.WriteLine("Invalid city selection.");
            }
        }

        static void PlanRoundTrip(Dictionary<string, List<string>> flightData, string startCity)
        {
            Console.WriteLine($"Starting from {startCity}");
            List<string> visitedCities = new List<string> { startCity };
            string currentCity = startCity;

            while (true)
            {
                List<string> destinations = flightData[currentCity];
                Console.WriteLine($"From {currentCity}, you can fly directly to:");
                foreach (string destination in destinations)
                {
                    Console.WriteLine(destination);
                }

                Console.WriteLine("Where would you like to go next? (or type 'exit' to finish)");
                string nextCity = Console.ReadLine();

                if (nextCity.ToLower() == "exit")
                {
                    if (visitedCities.Contains(startCity))
                    {
                        Console.WriteLine("Round-trip route selected:");
                        foreach (string city in visitedCities)
                        {
                            Console.WriteLine(city);
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You must select a route that returns to the starting city.");
                    }
                }
                else if (destinations.Contains(nextCity))
                {
                    visitedCities.Add(nextCity);
                    currentCity = nextCity;
                }
                else
                {
                    Console.WriteLine("Invalid destination.");
                }
            }
        }
    }
}