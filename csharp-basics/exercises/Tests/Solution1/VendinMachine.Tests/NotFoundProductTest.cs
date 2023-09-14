using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendingMachine;

namespace VendingMachine.Tests
{
    [TestClass]
    public class NotFoundProductTests
    {
        [TestMethod]
        public void NotFoundProduct_ShouldHaveCorrectName()
        {
            var notFoundProduct = new NotFoundProduct();

            Assert.AreEqual("Not Found", notFoundProduct.Name);
        }

        [TestMethod]
        public void NotFoundProduct_ShouldHaveZeroPrice()
        {
            var notFoundProduct = new NotFoundProduct();

            Assert.AreEqual(0, notFoundProduct.Price.Euros);
            Assert.AreEqual(0, notFoundProduct.Price.Cents);
        }

        [TestMethod]
        public void NotFoundProduct_ShouldHaveZeroAvailability()
        {
            var notFoundProduct = new NotFoundProduct();

            Assert.AreEqual(0, notFoundProduct.Available);
        }
    }
}