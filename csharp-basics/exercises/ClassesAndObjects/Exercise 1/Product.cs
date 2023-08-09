using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Product
    {
        public string Name { get; private set; }
        public double Price { get; private set; }
        public int Amount { get; private set; }

        public Product(string name, double priceAtStart, int amountAtStart)
        {
            Name = name;
            Price = priceAtStart;
            Amount = amountAtStart;
        }

        public void PrintProduct()
        {
            Console.WriteLine($"{Name}, price {Price.ToString("F2")} EUR, amount {Amount}");
        }

        public void ChangeQuantity(int newAmount)
        {
            if (newAmount >= 0)
            {
                Amount = newAmount;
            }
            else
            {
                Console.WriteLine("Invalid quantity.");
            }
        }

        public void ChangePrice(double newPrice)
        {
            if (newPrice >= 0)
            {
                Price = newPrice;
            }
            else
            {
                Console.WriteLine("Invalid price.");
            }
        }
    }
} 