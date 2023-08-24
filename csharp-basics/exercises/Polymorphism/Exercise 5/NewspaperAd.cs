using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    class NewspaperAd : Advert
    {
        private double columnCm;

        public NewspaperAd(double baseCost, double columnCm) : base(baseCost)
        {
            this.columnCm = columnCm;
        }

        public override double CalculateCost()
        {
            return base.CalculateCost() * columnCm;
        }
    }
}