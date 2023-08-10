using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    internal class Odometer
    {
        private int currentMileage;
        private FuelGauge fuelGauge;

        public Odometer(FuelGauge fuelGauge)
        {
            currentMileage = 0;
            this.fuelGauge = fuelGauge;
        }

        public int CurrentMileage
        {
            get { return currentMileage; }
        }

        public void IncrementMileage()
        {
            if (currentMileage < 999999)
            {
                currentMileage++;
            }
            else
            {
                currentMileage = 0;
            }

            if (currentMileage % 10 == 0)
            {
                fuelGauge.DecrementFuel();
            }
        }
    }
}