using System;
using System.Numerics;

namespace FuelConsumptionCalculator
{
    class CarTest
    {
        static void Main(string[] args)
        {
            Car car1 = new Car(1000);
            car1.FillUp(1200, 50);
            car1.FillUp(1500, 40);

            Car car2 = new Car(2000);
            car2.FillUp(2200, 60);
            car2.FillUp(2500, 30);

            Console.WriteLine("Car 1 Consumption: " + car1.CalculateConsumption() + " l/100 km");
            Console.WriteLine("Car 1 Gas Hog: " + car1.IsGasHog());
            Console.WriteLine("Car 1 Economy Car: " + car1.IsEconomyCar());

            Console.WriteLine("Car 2 Consumption: " + car2.CalculateConsumption() + " l/100 km");
            Console.WriteLine("Car 2 Gas Hog: " + car2.IsGasHog());
            Console.WriteLine("Car 2 Economy Car: " + car2.IsEconomyCar());
        }
    }
}