namespace Hierarchy.Test
{
    [TestClass]
    public class ZebraTests
    {
        [TestMethod]
        public void Animal_Eat_ShouldIncreaseFoodEaten()
        {
            // Arrange
            var animal = new Zebra("TestZebra", 400.5, "Savannah");
            var food = new Vegetable(3);

            // Act
            animal.Eat(food);

            // Assert
            Assert.AreEqual(3, animal.FoodEaten);
        }

        [TestMethod]
        public void Zebra_WillEatFood_ShouldReturnTrueForVegetable()
        {
            // Arrange
            var zebra = new Zebra("TestZebra", 400.5, "Savannah");
            var food = new Vegetable(1);

            // Act
            var result = zebra.WillEatFood(food);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Zebra_WillEatFood_ShouldReturnFalseForMeat()
        {
            // Arrange
            var zebra = new Zebra("TestZebra", 400.5, "Savannah");
            var food = new Meat(1);

            // Act
            var result = zebra.WillEatFood(food);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Zebra_MakeSound_ShouldReturnExpectedSound()
        {
            var zebra = new Zebra("TestZebra", 400.5, "Savannah");

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                zebra.MakeSound();

                var consoleOutput = sw.ToString().Trim();
                Assert.AreEqual("> Zeeebra", consoleOutput);
            }
        }
    }
}