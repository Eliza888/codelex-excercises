namespace ScooterRental
{
    public class SystemTimeService : ITimeService
    {
        public DateTime GetCurrentTime()
        {
            return DateTime.Now;
        }
    }
}
