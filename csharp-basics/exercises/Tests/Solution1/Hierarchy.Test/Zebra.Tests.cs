namespace Hierarchy.Test
{
    [TestClass]
    public class ZebraTests
    {
        [TestMethod]
        public void Animal_Eat_ShouldIncreaseFoodEaten()
        {
            var animal = new Zebra("TestZebra", 400.5, "Savannah");
            var food = new Vegetable(3);

            animal.Eat(food);

            Assert.AreEqual(3, animal.FoodEaten);
        }

        [TestMethod]
        public void Zebra_WillEatFood_ShouldReturnTrueForVegetable()
        {
            var zebra = new Zebra("TestZebra", 400.5, "Savannah");
            var food = new Vegetable(1);

            var result = zebra.WillEatFood(food);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Zebra_WillEatFood_ShouldReturnFalseForMeat()
        {
            var zebra = new Zebra("TestZebra", 400.5, "Savannah");
            var food = new Meat(1);

            var result = zebra.WillEatFood(food);

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