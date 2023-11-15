using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScooterRental;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ScooterRental.Tests
{
    [TestClass]
    public class ScooterServiceTests
    {
        private ScooterService _scooterService;
        private List<Scooter> _scooterStorage;
        private const string DEFAULT_SCOOTER_ID = "1";
        private const decimal DEFAULT_PRICE_PER_MINUTE = 0.2m;

        [TestInitialize]
        public void Setup()
        {
            _scooterStorage = new List<Scooter>();
            _scooterService = new ScooterService(_scooterStorage);
        }

        [TestMethod]
        public void AddScooter_WithIdAndPricePerMinute_ScooterAdded()
        {
            _scooterService.AddScooter(DEFAULT_SCOOTER_ID, DEFAULT_PRICE_PER_MINUTE);

            _scooterStorage.Count.Should().Be(1);
        }

        [TestMethod]
        public void AddScooter_WithIdAndPricePerMinute1_ScooterAddedWithId1AndPrice1()
        {
            _scooterService.AddScooter(DEFAULT_SCOOTER_ID, 1m);

            var scooter = _scooterStorage.First();

            scooter.Id.Should().Be(DEFAULT_SCOOTER_ID);
            scooter.PricePerMinute.Should().Be(1m);
        }

        [TestMethod]
        public void AddScooter_AddDuplivateScooter_ThrowsDuplicateScooterException()
        {
            _scooterStorage.Add(new Scooter(DEFAULT_SCOOTER_ID, DEFAULT_PRICE_PER_MINUTE));

            Action action = () => _scooterService.AddScooter(DEFAULT_SCOOTER_ID, DEFAULT_PRICE_PER_MINUTE);

            action.Should().Throw<DuplicateScooterException>();
        }

        [TestMethod]
        public void AddScooter_AddScooterWithNegativePrice_ThrowsNegativePriceException()
        {
            Action action = () => _scooterService.AddScooter(DEFAULT_SCOOTER_ID, -1);

            action.Should().Throw<NegativePriceException>();
        }

        [TestMethod]
        public void AddScooter_AddScooterWithEmptyId_ThrowsInvalidIdException()
        {
            Action action = () => _scooterService.AddScooter(DEFAULT_SCOOTER_ID, -1);

            action.Should().Throw<NegativePriceException>();
        }

        [TestMethod]
        public void RemoveScooter_ShouldRemoveUnrentedScooter()
        {
            var scooterId = "Scooter001";
            var scooterService = new ScooterService(new List<Scooter>());
            scooterService.AddScooter(scooterId, 0.5m);
            scooterService.RemoveScooter(scooterId);
            Assert.AreEqual(0, scooterService.GetScooters().Count);
        }
    }
}