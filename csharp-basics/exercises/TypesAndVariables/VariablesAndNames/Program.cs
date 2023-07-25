using System;

namespace VariablesAndNames
{
    class Program
    {
        private static void Main(string[] args)
        {
 

           int Cars = 100; 
           double SeatsInCar = 4.0;
           int Drivers = 28; 
           int Passengers = 90;


            int CarsNotDriven = cars - drivers;
            int CarsDriven = drivers;
            double CarpoolCapacity = carsDriven * SeatsInCar;
            double AveragePassengersPerCar = Math.Round((double)passengers / carsDriven, 2);


            Console.WriteLine("There are " + Cars + " cars available.");
            Console.WriteLine("There are only " + Drivers + " drivers available.");
            Console.WriteLine("There will be " + CarsNotDriven + " empty cars today.");
            Console.WriteLine("We can transport " + CarpoolCapacity + " people today.");
            Console.WriteLine("We have " + Passengers + " to carpool today.");
            Console.WriteLine("We need to put about " + AveragePassengersPerCar + " in each car.");
            Console.ReadKey();
        }
    }
}