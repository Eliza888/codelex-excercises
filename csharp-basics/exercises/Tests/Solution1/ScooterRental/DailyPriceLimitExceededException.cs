namespace ScooterRental.Exceptions
{
    public class DailyPriceLimitExceededException : Exception
    {
        public DailyPriceLimitExceededException()
            : base("The daily rental price limit has been exceeded.")
        {
        }
    }
}