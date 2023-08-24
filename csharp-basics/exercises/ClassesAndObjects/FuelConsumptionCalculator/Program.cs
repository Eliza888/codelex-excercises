using System;
using System.Numerics;

namespace FuelConsumptionCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car(1000);
            car1.FillUp(1200, 50);
            car1.FillUp(1500, 40);

            Car car2 = new Car(2000);
            car2.FillUp(2200, 60);
            car2.FillUp(2500, 30);

            Car car3 = new Car(3000);
            car3.FillUp(3300, 70);
            car3.FillUp(3700, 50);
            
            Console.WriteLine("Car 1 Consumption: " + car1.CalculateConsumption() + " l/100 km");
            Console.WriteLine("Car 1 Gas Hog: " + car1.IsGasHog());
            Console.WriteLine("Car 1 Economy Car: " + car1.IsEconomyCar());

            Console.WriteLine("Car 2 Consumption: " + car2.CalculateConsumption() + " l/100 km");
            Console.WriteLine("Car 2 Gas Hog: " + car2.IsGasHog());
            Console.WriteLine("Car 2 Economy Car: " + car2.IsEconomyCar());

            Console.WriteLine("Car 3 Consumption: " + car3.CalculateConsumption() + " l/100 km");
            Console.WriteLine("Car 3 Gas Hog: " + car3.IsGasHog());
            Console.WriteLine("Car 3 Economy Car: " + car3.IsEconomyCar());
        }
    }
}