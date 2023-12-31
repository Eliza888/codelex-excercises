﻿using System;
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
        private double startKilometers;
        private double endKilometers;
        private double liters;

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
            return endKilometers == startKilometers ? 0.0 : (liters / (endKilometers - startKilometers)) * 100;
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