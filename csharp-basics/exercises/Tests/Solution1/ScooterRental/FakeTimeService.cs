namespace ScooterRental
{
    public class FakeTimeService : ITimeService
    {
        private DateTime _currentTime;

        public FakeTimeService(DateTime initialTime)
        {
            _currentTime = initialTime;
        }

        public DateTime GetCurrentTime()
        {
            return _currentTime;
        }

        public void AdvanceTime(TimeSpan timeSpan)
        {
            _currentTime += timeSpan;
        }

        public DateTime CurrentTime => DateTime.Now;
    }
}