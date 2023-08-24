using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    class Hoarding : Advert
    {
        private int days;
        private bool primeLocation;

        public Hoarding(double baseCost, int days, bool primeLocation) : base(baseCost)
        {
            this.days = days;
            this.primeLocation = primeLocation;
        }

        public override double CalculateCost()
        {
            double totalCost = base.CalculateCost() * days;
            if (primeLocation)
            {
                totalCost *= 1.5;
            }
            return totalCost;
        }
    }
}