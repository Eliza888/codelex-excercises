using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hierarchy;
using System.Globalization;

namespace Hierarchy.Tests
{
    [TestClass]
    public class AnimalTests
    {
        [TestMethod]
        public void Animal_ToString_ShouldReturnExpectedString()
        {
            var animal = new Cat("Gray", 1.10, "Home", "Persian");

            string actualString = animal.ToString();

            string expectedString = $"Cat Gray 1,10 Home Persian";

            Assert.AreEqual(expectedString, actualString);
        }
        
        [TestMethod]
        public void AnimalType_ShouldReturnCorrectValue()
        {
            // Arrange
            var mouse = new Mouse("Squeaky", 0.1, "Field");
            var tiger = new Tiger("Typcho", 167.7, "Asia");

            string mouseType = mouse.AnimalType;
            string tigerType = tiger.AnimalType;

            Assert.AreEqual("Mouse", mouseType);
            Assert.AreEqual("Feline", tigerType);
        }
    }
}