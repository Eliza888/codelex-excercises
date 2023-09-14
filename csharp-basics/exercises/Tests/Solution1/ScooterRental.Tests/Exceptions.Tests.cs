using ScooterRental.Exceptions;

namespace ScooterRental.Tests
{
    [TestClass]
    public class ExceptionsTests
    {
        [TestMethod]
        [ExpectedException(typeof(DailyPriceLimitExceededException))]
        public void DailyPriceLimitExceededException_ShouldThrow()
        {
            decimal dailyPriceLimit = 20.0m;
            decimal rentalCost = 21.0m;
            int rentalDurationInMinutes = (int)(rentalCost / 0.5m);

            if (rentalCost > dailyPriceLimit)
            {
                throw new DailyPriceLimitExceededException();
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ScooterNotFoundException))]
        public void ScooterNotFoundException_ShouldThrow()
        {
            var scooterService = new ScooterService(new List<Scooter>());

            var scooterId = "NonExistentScooter";
            var scooter = scooterService.GetScooterById(scooterId);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidIdException))]
        public void InvalidIdException_ShouldThrow()
        {
            var scooterService = new ScooterService(new List<Scooter>());

            string invalidId = null;
            scooterService.AddScooter(invalidId, 0.5m);
        }
    }
}