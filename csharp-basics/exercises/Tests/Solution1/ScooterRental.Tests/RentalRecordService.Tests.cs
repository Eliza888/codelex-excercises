using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScooterRental;
using System;
using System.Collections.Generic;

namespace ScooterRental.Tests
{
    [TestClass]
    public class RentalRecordServiceTests
    {
        private List<RentedScooter> _rentedScootersList;
        private RentalRecordService _rentalRecordService;

        [TestInitialize]
        public void Initialize()
        {
            _rentedScootersList = new List<RentedScooter>();
            _rentalRecordService = new RentalRecordService(_rentedScootersList);
        }

        [TestMethod]
        public void StopRent_ShouldSetRentEnd_ForUnfinishedRental()
        {
            DateTime initialTime = new DateTime(2022, 1, 1, 0, 0, 0);
            FakeTimeService timeService = new FakeTimeService(initialTime);
            var rentedScooterList = new List<RentedScooter>();
            RentalRecordService rentalRecordService = new RentalRecordService(rentedScooterList);
            var rentalRecord = new RentedScooter("Scooter001", initialTime);
            rentedScooterList.Add(rentalRecord);
            string scooterId = "Scooter001";
            DateTime rentEnd = initialTime.AddMinutes(30);

            var stoppedRental = rentalRecordService.StopRent(scooterId, rentEnd);

            Assert.IsNotNull(stoppedRental);
            Assert.AreEqual(rentEnd, stoppedRental.RentEnd);
        }

        [TestMethod]
        public void StopRent_ShouldNotModifyRentalRecord_ForFinishedRental()
        {
            DateTime initialTime = new DateTime(2022, 1, 1, 0, 0, 0);
            FakeTimeService timeService = new FakeTimeService(initialTime);
            var rentedScooterList = new List<RentedScooter>();
            RentalRecordService rentalRecordService = new RentalRecordService(rentedScooterList);
            var rentalRecord = new RentedScooter("Scooter001", initialTime);
            rentalRecord.RentEnd = initialTime.AddMinutes(30);
            rentedScooterList.Add(rentalRecord);
            string scooterId = "Scooter001";
            DateTime rentEnd = initialTime.AddMinutes(45);

            var stoppedRental = rentalRecordService.StopRent(scooterId, rentEnd);

            Assert.IsNull(stoppedRental);
            Assert.AreEqual(initialTime.AddMinutes(30), rentalRecord.RentEnd);
        }

        [TestMethod]
        public void StopRent_ShouldReturnNull_ForNonexistentRental()
        {
            DateTime initialTime = new DateTime(2022, 1, 1, 0, 0, 0);
            FakeTimeService timeService = new FakeTimeService(initialTime);
            var rentedScooterList = new List<RentedScooter>();
            RentalRecordService rentalRecordService = new RentalRecordService(rentedScooterList);
            string scooterId = "Scooter001";
            DateTime rentEnd = initialTime.AddMinutes(30);

            var stoppedRental = rentalRecordService.StopRent(scooterId, rentEnd);

            Assert.IsNull(stoppedRental);
        }

        [TestMethod]
        public void RentedScootersList_ShouldReturnTheSameList()
        {
            var rentedScooter1 = new RentedScooter("Scooter001", DateTime.Now.AddMinutes(-30));
            var rentedScooter2 = new RentedScooter("Scooter002", DateTime.Now.AddMinutes(-45));

            _rentedScootersList.Add(rentedScooter1);
            _rentedScootersList.Add(rentedScooter2);

            CollectionAssert.AreEqual(_rentedScootersList, _rentalRecordService.RentedScootersList);
        }
    }
}