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

        public Product(string name, double price, int amount)
        {
            Name = name;
            Price = price;
            Amount = amount;
        }

        public void PrintProduct()
        {
            string formattedPrice = Price.ToString("0.00");
            Console.WriteLine($"{Name}, price {formattedPrice} EUR, amount {Amount}");
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