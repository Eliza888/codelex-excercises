namespace Hierarchy.Test
{
    [TestClass]
    public class TigerTests
    {
        [TestMethod]
        public void Animal_Eat_ShouldIncreaseFoodEaten()
        {
            // Arrange
            var animal = new Tiger("TestTiger", 167.7, "Asia");
            var food = new Meat(4);

            // Act
            animal.Eat(food);

            // Assert
            Assert.AreEqual(4, animal.FoodEaten);
        }

        [TestMethod]
        public void Tiger_WillEatFood_ShouldReturnTrueForMeat()
        {
            // Arrange
            var tiger = new Tiger("TestTiger", 167.7, "Asia");
            var food = new Meat(1);

            // Act
            var result = tiger.WillEatFood(food);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Tiger_WillEatFood_ShouldReturnFalseForVegetable()
        {
            // Arrange
            var tiger = new Tiger("TestTiger", 167.7, "Asia");
            var food = new Vegetable(1);

            // Act
            var result = tiger.WillEatFood(food);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Tiger_MakeSound_ShouldReturnExpectedSound()
        {
            var tiger = new Tiger("TestTiger", 167.7, "Asia");

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                tiger.MakeSound();

                var consoleOutput = sw.ToString().Trim();
                Assert.AreEqual("> ROAAR!!!", consoleOutput);
            }
        }
    }
}