namespace Hierarchy.Tests
{
    [TestClass]
    public class MouseTests
    {
        [TestMethod]
        public void Animal_Eat_ShouldIncreaseFoodEaten()
        {
            var animal = new Mouse("TestMouse", 0.1, "Field");
            var food = new Vegetable(2);

            animal.Eat(food);

            Assert.AreEqual(2, animal.FoodEaten);
        }

        [TestMethod]
        public void Mouse_WillEatFood_ShouldReturnTrueForVegetable()
        {
            var mouse = new Mouse("TestMouse", 0.1, "Field");
            var food = new Vegetable(1);

            var result = mouse.WillEatFood(food);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Mouse_WillEatFood_ShouldReturnFalseForMeat()
        {
            var mouse = new Mouse("TestMouse", 0.1, "Field");
            var food = new Meat(1);

            var result = mouse.WillEatFood(food);

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

        [TestMethod]
        public void Mouse_ToString_ShouldReturnExpectedString()
        {
            var mouse = new Mouse("Squeaky", 0.1, "Field");

            string
                expectedString =
                    "Mouse Squeaky 0.10 Field"; 
            string actualString = mouse.ToString();

            Assert.AreEqual(expectedString, actualString);
        }
    }
}