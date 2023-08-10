using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class FuelGauge
    {
        private int currentFuel;

        public FuelGauge()
        {
            currentFuel = 0;
        }

        public int CurrentFuel
        {
            get { return currentFuel; }
        }

        public void IncrementFuel()
        {
            if (currentFuel < 70)
            {
                currentFuel++;
            }
        }

        public void DecrementFuel()
        {
            if (currentFuel > 0)
            {
                currentFuel--;
            }
        }
    }
}