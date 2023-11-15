using ScooterRental;
using System;
using System.Collections.Generic;
using System.Linq;
using ScooterRental.Exceptions;

namespace ScooterRental
{
    public class RentalCompany : IRentalCompany
    {
        private readonly IRentalRecordService _rentalRecordsService;
        private readonly List<RentedScooter> _completedRentals = new List<RentedScooter>();
        private readonly ITimeService _timeService;
        private const decimal DefaultPricePerMinute = 0.5m;
        private readonly IScooterService _scooterService;
        private readonly Dictionary<string, decimal> _scooterIncome = new Dictionary<string, decimal>();
        private readonly List<Scooter> _scooters = new List<Scooter>();

        public RentalCompany(string name, IScooterService scooterService, IRentalRecordService rentalRecordsService, ITimeService timeService)
        {
            Name = name;
            _scooterService = scooterService;
            _rentalRecordsService = rentalRecordsService;
            _timeService = timeService;

            _scooterIncome["Scooter001"] = 0.0m;
            _scooterIncome["Scooter002"] = 0.0m;
            _scooterIncome["Scooter003"] = 0.0m;

            AddScooter("Scooter001", DefaultPricePerMinute);
            AddScooter("Scooter002", DefaultPricePerMinute);
            AddScooter("Scooter003", DefaultPricePerMinute);
        }

        public string Name { get; }

        public void AddScooter(string id, decimal pricePerMinute)
        {
            if (_scooters.Any(s => s.Id == id))
            {
                throw new DuplicateScooterException();
            }

            if (pricePerMinute <= 0)
            {
                throw new NegativePriceException();
            }

            if (string.IsNullOrEmpty(id))
            {
                throw new InvalidIdException();
            }

            _scooters.Add(new Scooter(id, pricePerMinute));
        }

        public void StartRent(string id)
        {
            var scooter = _scooters.FirstOrDefault(s => s.Id == id);

            if (scooter == null)
            {
                throw new InvalidOperationException("Scooter not found.");
            }

            if (scooter.IsRented)
            {
                throw new ScooterAlreadyRentedException(id);
            }

            scooter.IsRented = true;
            var rentalStartTime = _timeService.GetCurrentTime();
            _rentalRecordsService.StartRent(id, rentalStartTime);
        }

        public decimal EndRent(string id)
        {
            var scooter = _scooters.FirstOrDefault(s => s.Id == id);

            if (scooter == null)
            {
                throw new InvalidOperationException("Scooter not found.");
            }

            if (!scooter.IsRented)
            {
                return 0;
            }

            RentedScooter rentalRecord = CreateRentalRecord(id);
            decimal pricePerMinute = scooter.PricePerMinute;
            TimeSpan rentalDuration = _timeService.GetCurrentTime() - rentalRecord.RentStart;
            decimal totalCost = Math.Round((decimal)rentalDuration.TotalMinutes * pricePerMinute, 2);
            decimal maxPricePerDay = 20m;

            if (totalCost > maxPricePerDay)
            {
                totalCost = maxPricePerDay;
            }

            decimal minimumPricePerMinute = 0.5m;

            if (totalCost < minimumPricePerMinute)
            {
                totalCost = minimumPricePerMinute;
            }

            totalCost = Math.Round(totalCost, 2);
            rentalRecord.Price = totalCost;
            scooter.IsRented = false;
            _completedRentals.Add(rentalRecord);
            return rentalRecord.Price;
        }

        private RentedScooter CreateRentalRecord(string id)
        {
            var rentalStartTime = _timeService.GetCurrentTime();
            var rentalRecord = new RentedScooter(id, rentalStartTime);
            return rentalRecord;
        }

        public void AddRentalIncome(string scooterId, decimal income)
        {
            if (_scooterIncome.ContainsKey(scooterId))
            {
                _scooterIncome[scooterId] += income;
            }
            else
            {
                _scooterIncome[scooterId] = income;
            }
        }

        public decimal CalculateIncome(int? year, bool includeNotCompletedRentals)
        {
            decimal totalIncome = 0;

            foreach (var scooterId in _scooterIncome.Keys)
            {
                if (!year.HasValue || (_scooterIncome.ContainsKey(scooterId) && includeNotCompletedRentals))
                {
                    totalIncome += _scooterIncome[scooterId];
                }
            }

            return totalIncome;
        }
    }
}