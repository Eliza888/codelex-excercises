namespace Hierarchy.Test
{
    [TestClass]
    public class TigerTests
    {
        [TestMethod]
        public void Animal_Eat_ShouldIncreaseFoodEaten()
        {
            var animal = new Tiger("TestTiger", 167.7, "Asia");
            var food = new Meat(4);

            animal.Eat(food);

            Assert.AreEqual(4, animal.FoodEaten);
        }

        [TestMethod]
        public void Tiger_WillEatFood_ShouldReturnTrueForMeat()
        {
            var tiger = new Tiger("TestTiger", 167.7, "Asia");
            var food = new Meat(1);

            var result = tiger.WillEatFood(food);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Tiger_WillEatFood_ShouldReturnFalseForVegetable()
        {
            var tiger = new Tiger("TestTiger", 167.7, "Asia");
            var food = new Vegetable(1);

            var result = tiger.WillEatFood(food);

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