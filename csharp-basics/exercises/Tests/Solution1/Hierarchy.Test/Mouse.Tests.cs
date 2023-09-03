namespace Hierarchy.Tests
{
    [TestClass]
    public class MouseTests
    {
        [TestMethod]
        public void Animal_Eat_ShouldIncreaseFoodEaten()
        {
            // Arrange
            var animal = new Mouse("TestMouse", 0.1, "Field");
            var food = new Vegetable(2);

            // Act
            animal.Eat(food);

            // Assert
            Assert.AreEqual(2, animal.FoodEaten);
        }

        [TestMethod]
        public void Mouse_WillEatFood_ShouldReturnTrueForVegetable()
        {
            // Arrange
            var mouse = new Mouse("TestMouse", 0.1, "Field");
            var food = new Vegetable(1);

            // Act
            var result = mouse.WillEatFood(food);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Mouse_WillEatFood_ShouldReturnFalseForMeat()
        {
            // Arrange
            var mouse = new Mouse("TestMouse", 0.1, "Field");
            var food = new Meat(1);

            // Act
            var result = mouse.WillEatFood(food);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Mouse_MakeSound_ShouldReturnExpectedSound()
        {
            var mouse = new Mouse("TestMouse", 0.1, "Field");

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                mouse.MakeSound();

                var consoleOutput = sw.ToString().Trim();
                Assert.AreEqual("> Squeak", consoleOutput);
            }
        }
    }
}