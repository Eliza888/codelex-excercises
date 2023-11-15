using ScooterRental.Exceptions;

namespace ScooterRental.Exceptions
{
    public class ScooterAlreadyRentedException : Exception
    {
        public ScooterAlreadyRentedException(string scooterId)
            : base($"Scooter with ID '{scooterId}' is already rented.")
        {
        }
    }
}