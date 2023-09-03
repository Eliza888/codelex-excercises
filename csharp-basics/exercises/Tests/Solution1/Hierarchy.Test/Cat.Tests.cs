namespace Hierarchy.Tests
{
    [TestClass]
    public class CatTests
    {
        [TestMethod]
        public void Animal_Eat_ShouldIncreaseFoodEaten()
        {
            // Arrange
            var animal = new Cat("TestCat", 1.0, "Home", "Persian");
            var food = new Meat(2);

            // Act
            animal.Eat(food);

            // Assert
            Assert.AreEqual(2, animal.FoodEaten);
        }


        [TestMethod]
        public void Cat_WillEatFood_ShouldReturnTrueForMeat()
        {
            // Arrange
            var cat = new Cat("TestCat", 1.0, "Home", "Persian");
            var food = new Meat(1);

            // Act
            var result = cat.WillEatFood(food);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Cat_WillEatFood_ShouldReturnTrueForVegetable()
        {
            // Arrange
            var cat = new Cat("TestCat", 1.0, "Home", "Persian");
            var food = new Vegetable(1);

            // Act
            var result = cat.WillEatFood(food);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Cat_MakeSound_ShouldReturnExpectedSound()
        {
            var cat = new Cat("TestCat", 1.0, "Home", "Persian");

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                cat.MakeSound();

                var consoleOutput = sw.ToString().Trim();
                Assert.AreEqual("> Meeeooow", consoleOutput);
            }
        }
    }
}