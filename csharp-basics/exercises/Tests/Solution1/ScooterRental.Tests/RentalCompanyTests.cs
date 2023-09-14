using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScooterRental.Exceptions;
using ScooterRental;

namespace ScooterRental.Tests
{
    [TestClass]
    public class RentalCompanyTests
    {
        private List<Scooter> _scooterList;
        private List<RentedScooter> _rentedScootersList;
        private IRentalRecordService _rentalRecordsService;
        private IScooterService _scooterService;
        private ITimeService _timeService;
        private IRentalCompany _rentalCompany;

        [TestInitialize]
        public void Initialize()
        {
            _scooterList = new List<Scooter>();
            _rentedScootersList = new List<RentedScooter>();
            _timeService = new FakeTimeService(DateTime.Now);
            _rentalRecordsService = new RentalRecordService(_rentedScootersList);
            _scooterService = new ScooterService(_scooterList);

            _rentalCompany = new RentalCompany("TestCompany", _scooterService, _rentalRecordsService, _timeService);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void StartRent_WithInvalidScooterId_ShouldThrowException()
        {
            var invalidScooterId = "InvalidScooterId";
            _rentalCompany.StartRent(invalidScooterId);
        }

        [TestMethod]
        public void StartRent_WithNonExistentScooter_ShouldThrowException()
        {
            var nonExistentScooterId = "NonExistentScooterId";
            Assert.ThrowsException<InvalidOperationException>(() => _rentalCompany.StartRent(nonExistentScooterId));
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void EndRent_EndingNonExistentScooter_ShouldThrowException()
        {
            var nonExistentScooterId = "NonExistentScooterId";
            _rentalCompany.EndRent(nonExistentScooterId);
        }

        [TestMethod]
        public void StartRent_ShouldThrowException_WhenScooterNotFound()
        {
            var nonExistentScooterId = "NonExistentScooterId";
            Assert.ThrowsException<InvalidOperationException>(() => _rentalCompany.StartRent(nonExistentScooterId));
        }

        [TestMethod]
        public void StartRent_ShouldStartRental_WhenScooterIsAvailable()
        {
            var scooterId = "Scooter001";
            _scooterList.Add(new Scooter(scooterId, 0.5m));
            _rentalCompany.StartRent(scooterId);
            var rentedScooter = _rentedScootersList.SingleOrDefault(s => s.Id == scooterId);
            Assert.IsNotNull(rentedScooter);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void EndRent_WithInvalidScooterId_ShouldThrowException()
        {
            var invalidScooterId = "InvalidScooterId";
            _rentalCompany.EndRent(invalidScooterId);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void EndRent_WithNonExistentScooter_ShouldThrowException()
        {
            var nonExistentScooterId = "NonExistentScooterId";
            _rentalCompany.EndRent(nonExistentScooterId);
        }

        [TestMethod]
        public void EndRent_ForAvailableScooter_ShouldReturnZero()
        {
            var scooterId = "Scooter001";
            _scooterList.Add(new Scooter(scooterId, 0.5m));
            var price = _rentalCompany.EndRent(scooterId);
            Assert.AreEqual(0, price);
            Assert.IsFalse(_rentedScootersList.Any());
            Assert.IsFalse(_scooterList.Single(s => s.Id == scooterId).IsRented);
        }

        [TestMethod]
        public void EndRent_ShouldThrowException_WhenScooterNotFound()
        {
            var scooterId = "NonExistentScooterId";
            Assert.ThrowsException<InvalidOperationException>(() => _rentalCompany.EndRent(scooterId));
        }

        [TestMethod]
        public void EndRent_WhenScooterIsNotRented_ReturnsZero()
        {
            var scooterId = "Scooter001";
            _scooterList.Add(new Scooter(scooterId, 0.5m));
            var price = _rentalCompany.EndRent(scooterId);
            Assert.AreEqual(0, price);
        }

        [TestMethod]
        public void EndRent_WithDailyPriceLimit_ShouldApplyLimit()
        {
            var scooterId = "Scooter001";
            var scooterPrice = 1.0m;
            _scooterList.Add(new Scooter(scooterId, scooterPrice));
            _rentalCompany.StartRent(scooterId);
            var price = _rentalCompany.EndRent(scooterId);
            Assert.AreEqual(0.5m, price);
        }

        [TestMethod]
        public void CalculateIncome_ShouldCalculateIncomeForCompletedRentalsOnly()
        {
            var initialTime = new DateTime(2022, 1, 1, 0, 0, 0);
            var timeService = new FakeTimeService(initialTime);
            var rentedScootersList = new List<RentedScooter>();
            var rentalRecordService = new RentalRecordService(rentedScootersList);
            var scooterService = new ScooterService(new List<Scooter>());
            var rentalCompany = new RentalCompany("MyRentalCompany", scooterService, rentalRecordService, timeService);
            rentalCompany.AddRentalIncome("Scooter001", 0.5m);
            rentalCompany.AddRentalIncome("Scooter002", 0.0m);
            decimal income2022 = rentalCompany.CalculateIncome(2022, true);
            decimal income2023 = rentalCompany.CalculateIncome(2023, true);
            Assert.AreEqual(0.5m, income2022);
            Assert.AreEqual(0.5m, income2023);
        }
    }
}