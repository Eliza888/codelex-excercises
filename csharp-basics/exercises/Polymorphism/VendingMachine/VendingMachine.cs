using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;
using VendingMachine;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace VendingMachine
{
    public class VendingMachine : IVendingMachine
    {
        private string _manufacturer;
        private List<Product> _products = new List<Product>();
        private Money _amount = new Money { Euros = 10, Cents = 0 }; // Initialize to 10.00

        public VendingMachine(string manufacturer, Product[] initialProducts)
        {
            _manufacturer = manufacturer;
            _products.AddRange(initialProducts);
        }

        public string Manufacturer => _manufacturer;

        public bool HasProducts => _products.Exists(product => product.Available > 0);

        public Money Amount => _amount;

        public Product[] Products => _products.ToArray();

        public Money InsertCoin(Money amount)
        {
            if (IsValidCoin(amount))
            {
                _amount.Euros += amount.Euros;
                _amount.Cents += amount.Cents;

                if (_amount.Cents >= 100)
                {
                    _amount.Euros += _amount.Cents / 100;
                    _amount.Cents %= 100;
                }
            }

            return _amount;
        }


        public Money ReturnMoney()
        {
            Money returnedAmount = new Money
            {
                Euros = _amount.Euros,
                Cents = _amount.Cents
            };

            _amount.Euros = 0;
            _amount.Cents = 0;

            return returnedAmount;
        }

        public bool AddProduct(string name, Money price, int count)
        {
            if (count <= 0 || _products.Exists(product => product.Name == name))
            {
                return false;
            }

            _products.Add(new Product
            {
                Name = name,
                Price = price,
                Available = count
            });

            return true;
        }

        public bool UpdateProduct(int productNumber, string name, Money? price, int amount)
        {
            if (productNumber < 0 || productNumber >= _products.Count)
            {
                return false;
            }

            Product productToUpdate = _products[productNumber];

            if (!string.IsNullOrEmpty(name))
            {
                productToUpdate.Name = name;
            }

            if (price.HasValue)
            {
                productToUpdate.Price = price.Value;
            }

            if (amount >= 0)
            {
                productToUpdate.Available = amount;
            }

            return true;
        }

        private bool IsValidCoin(Money coin)
        {
            return coin.Euros >= 0 && (coin.Cents == 10 || coin.Cents == 20 || coin.Cents == 50 ||
                                       coin.Cents == 0 && (coin.Euros == 1 || coin.Euros == 2));
        }

        public class NotFoundProduct
        {
            public string Name { get; } = "Not Found";
            public Money Price { get; } = new Money();
            public int Available { get; } = 0;
        }

        public NotFoundProduct GetNotFoundProduct()
        {
            return new NotFoundProduct();
        }

        public bool TryDecrementProductAvailability(string productName)
        {
            for (int i = 0; i < _products.Count; i++)
            {
                if (_products[i].Name == productName)
                {
                    _products[i] = new Product
                    {
                        Name = _products[i].Name,
                        Price = _products[i].Price,
                        Available = _products[i].Available - 1
                    };
                    return true;
                }
            }

            Console.WriteLine("Product not found in the list.");
            return false;
        }

        public IProduct FindProductByName(string productName)
        {
            foreach (var product in _products)
            {
                if (string.Equals(product.Name, productName, StringComparison.OrdinalIgnoreCase))
                {
                    return new ProductWrapper(product);
                }
            }

            // Handle the case when the product is not found
            return new ProductWrapper(new Product
            {
                Name = "Not Found",
                Price = new Money(),
                Available = 0
            });
        }
    }
}
