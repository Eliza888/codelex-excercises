using ScooterRental.Exceptions;

namespace ScooterRental
{
    public class ScooterService : IScooterService
    {
        private readonly List<Scooter> _scooters;
        public ScooterService(List<Scooter> scooterStorage)
        {
            _scooters = scooterStorage;
        }
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

        public void RemoveScooter(string id)
        {
            var scooter = GetScooterById(id);

            if (scooter == null)
            {
                throw new ArgumentException("Scooter not found.");
            }

            if (scooter.IsRented)
            {
                throw new InvalidOperationException("Cannot remove a rented scooter.");
            }

            _scooters.Remove(scooter);
        }

        public IList<Scooter> GetScooters() 
        {
            return _scooters.ToList();
        }

        public Scooter GetScooterById(string id)
        {
            var scooter = _scooters.FirstOrDefault(s => s.Id == id);

            if (scooter == null)
            {
                throw new ScooterNotFoundException(id);
            }

            return scooter;
        }
    }
}