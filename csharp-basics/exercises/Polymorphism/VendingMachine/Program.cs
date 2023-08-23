using System;
using System.Globalization;

namespace VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product[] initialProducts = new Product[]
            {
                new Product { Name = "Soda", Price = new Money { Euros = 1, Cents = 50 }, Available = 5 },
                new Product { Name = "Chips", Price = new Money { Euros = 2, Cents = 0 }, Available = 3 }
            };

            IVendingMachine vendingMachine = new VendingMachine("Example Manufacturer", initialProducts);

            Console.WriteLine("Welcome to the Vending Machine!");
            DisplayProducts(vendingMachine);

            while (true)
            {
                Console.WriteLine("\nEnter the name of the product you want to buy (or 'exit' to quit):");
                string productName = Console.ReadLine();

                if (productName.ToLower() == "exit")
                {
                    break;
                }

                Product selectedProduct = FindProductByName(vendingMachine.Products, productName);

                if (ReferenceEquals(selectedProduct, default(Product))) // Check for default value
                {
                    Console.WriteLine("Invalid product name. Please try again.");
                }
                else
                {
                    Console.WriteLine($"Selected product: {selectedProduct.Name} - Price: {selectedProduct.Price.Euros}.{selectedProduct.Price.Cents:D2}");

                    Console.Write("Enter the amount you want to pay: ");
                    string inputAmount = Console.ReadLine();
                    decimal paymentAmount;
                    if (decimal.TryParse(inputAmount, NumberStyles.Currency, CultureInfo.InvariantCulture, out paymentAmount))
                    {
                        if (IsValidCoin(paymentAmount))
                        {
                            Money paymentMoney = new Money { Euros = (int)paymentAmount, Cents = (int)((paymentAmount - (int)paymentAmount) * 100) };
                            Money change = BuyProduct(vendingMachine, selectedProduct, paymentMoney);
                            DisplayProducts(vendingMachine);
                        }
                        else
                        {
                            Console.WriteLine("Invalid coin. Please use valid coins: 0.10, 0.20, 0.50, 1.00, 2.00");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid amount. Please enter a valid numeric value.");
                    }
                }
            }
        }
        static void DisplayProducts(IVendingMachine vendingMachine)
        {
            Console.WriteLine("\nAvailable Products:");
            foreach (var product in vendingMachine.Products)
            {
                Console.WriteLine($"{product.Name} - Price: {product.Price.Euros}.{product.Price.Cents:D2} - Available: {product.Available}");
            }
        }

        static Money BuyProduct(IVendingMachine vendingMachine, Product selectedProduct, Money paymentAmount)
        {
            Money change = CalculateChange(paymentAmount, selectedProduct.Price);

            if (selectedProduct.Available > 0 && change.Euros >= 0 && change.Cents >= 0)
            {
                int productIndex = Array.IndexOf(vendingMachine.Products, selectedProduct);
                if (productIndex >= 0)
                {
                    vendingMachine.UpdateProduct(productIndex, null, null, selectedProduct.Available - 1);
                    Console.WriteLine($"Thank you for your purchase! Enjoy your {selectedProduct.Name}. Your change is {change.Euros}.{change.Cents:D2}");
                }
                else
                {
                    Console.WriteLine($"Sorry, {selectedProduct.Name} is out of stock.");
                }
            }
            else if (selectedProduct.Available <= 0)
            {
                Console.WriteLine($"Sorry, {selectedProduct.Name} is out of stock.");
            }
            else
            {
                Console.WriteLine("Insufficient payment. Please insert enough money.");
            }

            return change;
        }

        static bool IsValidCoin(decimal coinAmount)
        {
            return coinAmount == 0.10m || coinAmount == 0.20m || coinAmount == 0.50m || coinAmount == 1.00m || coinAmount == 2.00m;
        }

        static Money CalculateChange(Money insertedAmount, Money price)
        {
            int totalInsertedCents = insertedAmount.Euros * 100 + insertedAmount.Cents;
            int totalProductCents = price.Euros * 100 + price.Cents;
            int changeCents = totalInsertedCents - totalProductCents;

            int changeEuros = changeCents / 100;
            int remainingCents = changeCents % 100;

            return new Money { Euros = changeEuros, Cents = remainingCents };
        }

        static Product FindProductByName(Product[] products, string productName)
        {
            foreach (var product in products)
            {
                if (string.Equals(product.Name, productName, StringComparison.OrdinalIgnoreCase))
                {
                    return product;
                }
            }
            return default(Product);
        }
    }
}