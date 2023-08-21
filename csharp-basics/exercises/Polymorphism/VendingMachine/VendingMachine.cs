using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class VendingMachine : IVendingMachine
    {

        public VendingMachine(string manufacturer)
        {
            Manufacturer = manufacturer;
        }
        private List<Product> _products = new List<Product>();
        public string Manufacturer { get; }

        public bool HasProducts { get; }

        public Money Amount { get; }

        public Product[] Products => _products.ToArray();

        public Money InsertCoin(Money amount)
        {
            throw new NotImplementedException();
        }

        public Money ReturnMoney()
        {
            throw new NotImplementedException();
        }

        public bool AddProduct(string name, Money price, int count)
        {
            throw new NotImplementedException();
        }

        public bool UpdateProduct(int productNumber, string name, Money? price, int amount)
        {
            throw new NotImplementedException();
        }
    }
}