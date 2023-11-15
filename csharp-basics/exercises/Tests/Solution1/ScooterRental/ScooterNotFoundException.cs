using System;

namespace ScooterRental.Exceptions
{
    public class ScooterNotFoundException : Exception
    {
        public ScooterNotFoundException(string scooterId)
            : base($"Scooter with ID '{scooterId}' not found.")
        {
        }
    }
}