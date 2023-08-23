using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace VendingMachine
{
    public class NotFoundProduct : IProduct
    {
        public string Name { get; set; }
        public Money Price { get; set; }
        public int Available { get; set; }

        public NotFoundProduct()
        {
            Name = "Not Found";
            Price = new Money();
            Available = 0;
        }
    }
}
