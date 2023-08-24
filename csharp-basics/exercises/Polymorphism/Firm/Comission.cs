using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm
{
    class Commission : Hourly
    {
        private double totalSales;
        private double commissionRate;

        public Commission(string name, string address, string phone, string socialSecurityNumber, double hourlyPayRate, double commissionRate)
            : base(name, address, phone, socialSecurityNumber, hourlyPayRate)
        {
            this.commissionRate = commissionRate;
        }

        public void AddSales(double totalSales)
        {
            this.totalSales += totalSales;
        }

        public override double Pay()
        {
            double hourlyPayment = base.Pay();
            double commissionPayment = totalSales * commissionRate;
            totalSales = 0; // Reset total sales after calculating commission

            return hourlyPayment + commissionPayment;
        }

        public override string ToString()
        {
            string hourDetails = base.ToString();
            return hourDetails + "\nTotal Sales: " + totalSales;
        }

        // Other methods and variables specific to the Commission class can be added here
    }
}
