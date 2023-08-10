using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FuelConsumptionCalculator
{
    public class Car
    {
        private double startKilometers; // Starting odometer reading
        private double endKilometers; // Ending odometer reading
        private double liters; // Liters of gas used between the readings

        public Car(double startOdo, double endOdo = 0, double gasLiters = 0)
        {
            startKilometers = startOdo;
            endKilometers = endOdo;
            liters = gasLiters;
        }

        public void FillUp(int mileage, double gasLiters)
        {
            endKilometers = mileage;
            liters += gasLiters;
        }

        public double CalculateConsumption()
        {
            if (endKilometers == startKilometers)
            {
                return 0.0;
            }
            return (liters / (endKilometers - startKilometers)) * 100;
        }

        public bool IsGasHog()
        {
            return CalculateConsumption() > 15.0;
        }

        public bool IsEconomyCar()
        {
            return CalculateConsumption() < 5.0;
        }
    }
}