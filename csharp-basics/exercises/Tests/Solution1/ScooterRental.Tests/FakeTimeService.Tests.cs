using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScooterRental;
using System;

namespace ScooterRental.Tests
{
    [TestClass]
    public class FakeTimeServiceTests
    {
        [TestMethod]
        public void GetCurrentTime_ShouldReturnInitialTime()
        {
            DateTime initialTime = new DateTime(2022, 1, 1, 0, 0, 0);
            FakeTimeService timeService = new FakeTimeService(initialTime);

            DateTime currentTime = timeService.GetCurrentTime();

            Assert.AreEqual(initialTime, currentTime);
        }

        [TestMethod]
        public void AdvanceTime_ShouldIncrementCurrentTime()
        {
            DateTime initialTime = new DateTime(2022, 1, 1, 0, 0, 0);
            FakeTimeService timeService = new FakeTimeService(initialTime);
            TimeSpan timeSpan = TimeSpan.FromHours(1);

            timeService.AdvanceTime(timeSpan);
            DateTime currentTime = timeService.GetCurrentTime();

            DateTime expectedTime = initialTime.Add(timeSpan);
            Assert.AreEqual(expectedTime, currentTime);
        }

        [TestMethod]
        public void CurrentTime_ShouldReturnCurrentSystemTime()
        {
            DateTime initialTime = new DateTime(2022, 1, 1, 0, 0, 0);
            FakeTimeService timeService = new FakeTimeService(initialTime);

            DateTime systemTime = DateTime.Now;
            DateTime currentTime = timeService.CurrentTime;

            TimeSpan tolerance = TimeSpan.FromSeconds(1); // Adjust as needed
            Assert.IsTrue(Math.Abs((systemTime - currentTime).TotalSeconds) <= tolerance.TotalSeconds);
        }
    }
}