using System;

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