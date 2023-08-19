using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    class Poster : Program
    {
        private double dimensions;
        private int copies;
        private double costPerCopy;

        public Poster(double baseCost, double dimensions, int copies, double costPerCopy) : base(baseCost)
        {
            this.dimensions = dimensions;
            this.copies = copies;
            this.costPerCopy = costPerCopy;
        }

        public override double CalculateCost()
        {
            double totalCost = base.CalculateCost() + (dimensions * copies * costPerCopy);
            return totalCost;
        }
    }
}