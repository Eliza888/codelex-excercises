using System;
using System.Collections.Generic;

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
                    car.ShowCurrentSpeed();
                    if (i == 3 && car is INitrous boostableCar)
                    {
                        boostableCar.UseNitrousOxideEngine();
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