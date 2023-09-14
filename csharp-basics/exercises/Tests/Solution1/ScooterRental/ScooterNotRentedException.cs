namespace ScooterRental
{
    public class ScooterNotRentedException : Exception
    {
        public ScooterNotRentedException() : base("Scooter is not currently rented.")
        {
        }
    }
}
