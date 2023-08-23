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

            VendingMachine vendingMachine = new VendingMachine("Example Manufacturer", initialProducts);

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

                IProduct selectedProduct = vendingMachine.FindProductByName(productName);

                if (selectedProduct == null || selectedProduct.Name == "Not Found")
                {
                    Console.WriteLine("Invalid product name. Please try again.");
                }
                else
                {
                    Console.WriteLine($"Selected product: {selectedProduct.Name} - Price: {selectedProduct.Price.Euros}.{selectedProduct.Price.Cents:D2}");

                    decimal totalPrice = selectedProduct.Price.Euros + selectedProduct.Price.Cents / 100m;
                    decimal paidAmount = 0;

                    while (paidAmount < totalPrice)
                    {
                        Console.Write($"Enter coins totaling {totalPrice - paidAmount:C2}: ");
                        string coinInput = Console.ReadLine();
                        if (decimal.TryParse(coinInput, NumberStyles.Currency, CultureInfo.InvariantCulture, out decimal coinValue))
                        {
                            if (IsValidCoin(coinValue))
                            {
                                paidAmount += coinValue;
                            }
                            else
                            {
                                Console.WriteLine("Invalid coin. Please use valid coins: 0.10, 0.20, 0.50, 1.00, 2.00");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid coin value. Please enter a valid numeric value.");
                        }
                    }

                    Money paymentMoney = new Money { Euros = (int)paidAmount, Cents = (int)((paidAmount - (int)paidAmount) * 100) };
                    Money change = CalculateChange(paymentMoney, selectedProduct.Price);

                    if (change.Euros >= 0 && change.Cents >= 0)
                    {
                        Console.WriteLine($"Change: {change.Euros}.{change.Cents:D2}");

                        // Update product availability
                        UpdateProductAvailability(vendingMachine, selectedProduct);

                        DisplayProducts(vendingMachine);
                    }
                    else
                    {
                        Console.WriteLine("Insufficient payment. Please enter enough money.");
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

            static void UpdateProductAvailability(VendingMachine vendingMachine, IProduct selectedProduct)
            {
                Console.WriteLine($"Checking availability before update: {selectedProduct.Available}");
                for (int i = 0; i < vendingMachine.Products.Length; i++)
                {
                    if (vendingMachine.Products[i].Name == selectedProduct.Name)
                    {
                        vendingMachine.Products[i].Available--;
                        Console.WriteLine($"Updating availability for: {selectedProduct.Name}");
                        break;
                    }
                }
                Console.WriteLine($"Checking availability after update: {selectedProduct.Available}");
            }
        }
    }
}