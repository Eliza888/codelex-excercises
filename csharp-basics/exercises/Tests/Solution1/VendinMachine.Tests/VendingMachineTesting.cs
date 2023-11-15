using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;
using System.Reflection.PortableExecutable;
using System.Text.RegularExpressions;
using VendingMachine;
using static System.Net.Mime.MediaTypeNames;

namespace VendingMachine.Tests
{
    [TestClass]
    public class VendingMachineTest
    {
        [TestMethod]
        public void InsertCoin_ShouldUpdateBalanceCorrectly()
        {
            VendingMachine vendingMachine = new VendingMachine("Test Manufacturer", new Product[0]);
            Money initialBalance = vendingMachine.Amount;
            Money insertedAmount = new Money { Euros = 1, Cents = 50 };

            Money updatedBalance = vendingMachine.InsertCoin(insertedAmount);

            Money expectedBalance = new Money { Euros = initialBalance.Euros + insertedAmount.Euros, Cents = initialBalance.Cents + insertedAmount.Cents };
            Assert.AreEqual(expectedBalance, updatedBalance);
        }

        [TestMethod]
        public void IsValidCoin_ShouldIdentifyValidAndInvalidCoins()
        {
            VendingMachine vendingMachine = new VendingMachine("Test Manufacturer", new Product[0]);

            Assert.IsTrue(vendingMachine.IsValidCoin(new Money { Euros = 0, Cents = 10 }));
            Assert.IsTrue(vendingMachine.IsValidCoin(new Money { Euros = 0, Cents = 20 }));
            Assert.IsTrue(vendingMachine.IsValidCoin(new Money { Euros = 0, Cents = 50 }));
            Assert.IsTrue(vendingMachine.IsValidCoin(new Money { Euros = 1, Cents = 0 }));
            Assert.IsTrue(vendingMachine.IsValidCoin(new Money { Euros = 2, Cents = 0 }));

            Assert.IsFalse(vendingMachine.IsValidCoin(new Money { Euros = 5, Cents = 0 }));
            Assert.IsFalse(vendingMachine.IsValidCoin(new Money { Euros = 0, Cents = 5 }));
            Assert.IsFalse(vendingMachine.IsValidCoin(new Money { Euros = -1, Cents = 50 }));
        }

        [TestMethod]
        public void CalculateChange_ShouldCalculateChangeCorrectly()
        {
            VendingMachine vendingMachine = new VendingMachine("Test Manufacturer", new Product[0]);
            Money insertedAmount = new Money { Euros = 5, Cents = 0 };
            Money productPrice = new Money { Euros = 2, Cents = 30 };

            Money change = vendingMachine.CalculateChange(insertedAmount, productPrice);

            Money expectedChange = new Money { Euros = 2, Cents = 70 };
            Assert.AreEqual(expectedChange, change);
        }

        [TestMethod]
        public void TryDecrementProductAvailability_ShouldDecrementAvailabilityForSpecificProduct()
        {
            Product[] initialProducts = new Product[]
            {
               new Product { Name = "Soda", Price = new Money { Euros = 1, Cents = 50 }, Available = 5 },
               new Product { Name = "Chips", Price = new Money { Euros = 2, Cents = 0 }, Available = 3 },
               new Product { Name = "Chocolate bar", Price = new Money { Euros = 2, Cents = 50 }, Available = 2 }
            };
            VendingMachine vendingMachine = new VendingMachine("Test Manufacturer", initialProducts);

            bool decrementSuccess = vendingMachine.TryDecrementProductAvailability("Soda");

            Assert.IsTrue(decrementSuccess);
            Assert.AreEqual(4, vendingMachine.FindProductByName("Soda").Available);
        }

        [TestMethod]
        public void UpdateProduct_ShouldNotChangeNameIfNull()
        {
            VendingMachine vendingMachine = new VendingMachine("Test Manufacturer", new Product[0]);
            vendingMachine.AddProduct("Soda", new Money { Euros = 1, Cents = 50 }, 5);
            int productNumber = 0;
            string updatedName = null;
            Money updatedPrice = new Money { Euros = 1, Cents = 50 };

            bool updated = vendingMachine.UpdateProduct(productNumber, updatedName, updatedPrice, -1);

            Assert.IsTrue(updated);
            Product updatedProduct = vendingMachine.Products[productNumber];
            Assert.AreEqual("Soda", updatedProduct.Name);
            Assert.AreEqual(new Money { Euros = 1, Cents = 50 }, updatedProduct.Price);
        }

        [TestMethod]
        public void UpdateProduct_ShouldNotChangePriceIfNull()
        {
            VendingMachine vendingMachine = new VendingMachine("Test Manufacturer", new Product[0]);
            vendingMachine.AddProduct("Soda", new Money { Euros = 1, Cents = 50 }, 5);
            int productNumber = 0;
            string updatedName = null;
            Money updatedPrice = new Money { Euros = 1, Cents = 50 };

            bool updated = vendingMachine.UpdateProduct(productNumber, updatedName, updatedPrice, -1);

            Assert.IsTrue(updated);
            Product updatedProduct = vendingMachine.Products[productNumber];
            Assert.AreEqual("Soda", updatedProduct.Name);
            Assert.AreEqual(new Money { Euros = 1, Cents = 50 }, updatedProduct.Price);
        }

        [TestMethod]
        public void AddProduct_ShouldReturnFalseForInvalidInput()
        {
            VendingMachine vendingMachine = new VendingMachine("Test Manufacturer", new Product[0]);
            Money validPrice = new Money { Euros = 1, Cents = 50 };
            int validCount = 5;
            string productName = "Soda";

            bool result1 = vendingMachine.AddProduct(productName, validPrice, validCount);
            bool result2 = vendingMachine.AddProduct(productName, validPrice, validCount);
            bool result3 = vendingMachine.AddProduct(productName, validPrice, -1);

            Assert.IsTrue(result1);
            Assert.IsFalse(result2);
            Assert.IsFalse(result3);
        }
        [TestMethod]
        public void ReturnMoney_ShouldReturnCorrectAmountAndResetBalance()
        {
            VendingMachine vendingMachine = new VendingMachine("Test Manufacturer", new Product[0]);
            Money initialBalance = new Money { Euros = 0, Cents = 0 };

            vendingMachine.InsertCoin(initialBalance);

            Money returnedAmount = vendingMachine.ReturnMoney();

            Assert.AreEqual(initialBalance.Euros, returnedAmount.Euros);
            Assert.AreEqual(initialBalance.Cents, returnedAmount.Cents);

            Money currentBalance = vendingMachine.Amount;
            Assert.AreEqual(0, currentBalance.Euros);
            Assert.AreEqual(0, currentBalance.Cents);
        }

        [TestMethod]
        [DataRow(true, 5)]
        [DataRow(false, 0)]
        public void HasProducts_ShouldReturnExpectedResult(bool expectedHasProducts, int availableProducts)
        {
            Product[] initialProducts = new Product[]
            {
            new Product { Name = "Soda", Price = new Money { Euros = 1, Cents = 50 }, Available = availableProducts }
            };
            VendingMachine vendingMachine = new VendingMachine("Test Manufacturer", initialProducts);

            bool actualHasProducts = vendingMachine.HasProducts;

            Assert.AreEqual(expectedHasProducts, actualHasProducts);
        }

        [TestMethod]
        public void FindProductByName_ShouldReturnDefaultProductWhenNotFound()
        {
            Product[] initialProducts = new Product[]
            {
                new Product { Name = "Soda", Price = new Money { Euros = 1, Cents = 50 }, Available = 5 },
                new Product { Name = "Chips", Price = new Money { Euros = 2, Cents = 0 }, Available = 3 },
                new Product { Name = "Chocolate bar", Price = new Money { Euros = 2, Cents = 50 }, Available = 2 }
            };
            VendingMachine vendingMachine = new VendingMachine("Test Manufacturer", initialProducts);

            IProduct notFoundProduct = vendingMachine.FindProductByName("Nonexistent Product");

            Assert.IsNotNull(notFoundProduct);
            Assert.AreEqual("Not Found", notFoundProduct.Name);
            Assert.AreEqual(new Money(), notFoundProduct.Price);
            Assert.AreEqual(0, notFoundProduct.Available);
        }

        [TestMethod]
        public void ManufacturerProperty_ShouldReturnExpectedValue()
        {
            string expectedManufacturer = "Test Manufacturer";
            VendingMachine vendingMachine = new VendingMachine(expectedManufacturer, new Product[0]);

            string actualManufacturer = vendingMachine.Manufacturer;

            Assert.AreEqual(expectedManufacturer, actualManufacturer);
        }
    }
}