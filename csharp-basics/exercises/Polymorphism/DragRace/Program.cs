using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;

namespace DragRace
{
    class Program
    {
        private static void Main(string[] args)
        {
            List<ICar> cars = new List<ICar>
            {
                new Tesla(),
                new Audi(),
                new Bmw(),
                new Lexus(),
                new Mercedes(),
                new Porsche()
            };

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Race {i}");
                foreach (var car in cars)
                {
                    car.SpeedUp();
                    Console.WriteLine($"{car.GetType().Name} - Current Speed: {car.ShowCurrentSpeed()}");

                    if (i == 3 && car is INitrous boostableCar)
                    {
                        boostableCar.UseNitrousOxideEngine();
                        Console.WriteLine($"{car.GetType().Name} used nitrous!");
                    }
                }
            }
            int maxSpeed = 0;
            string fastestCarName = "";
            foreach (var car in cars)
            {
                int currentSpeed = int.Parse(car.ShowCurrentSpeed());
                if (currentSpeed > maxSpeed)
                {
                    maxSpeed = currentSpeed;
                    fastestCarName = car.GetType().Name;
                }
            }

            Console.WriteLine($"The fastest car is {fastestCarName} with a speed of {maxSpeed}.");
        }
    }
}