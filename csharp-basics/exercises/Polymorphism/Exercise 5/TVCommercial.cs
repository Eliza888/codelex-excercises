using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    class TVCommercial : Program
    {
        private double seconds;
        private bool peakTime;

        public TVCommercial(double baseCost, double seconds, bool peakTime) : base(baseCost)
        {
            this.seconds = seconds;
            this.peakTime = peakTime;
        }

        public override double CalculateCost()
        {
            double totalCost = base.CalculateCost() * seconds;
            if (peakTime)
            {
                totalCost *= 2;
            }
            return totalCost;
        }
    }
}