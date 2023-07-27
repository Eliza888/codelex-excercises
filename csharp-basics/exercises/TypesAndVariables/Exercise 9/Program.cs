namespace Exercise_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("meters: ");
            double distanceInMeters = double.Parse(Console.ReadLine());

            Console.Write("hour: ");
            int hours = int.Parse(Console.ReadLine());

            Console.Write("minutes: ");
            int minutes = int.Parse(Console.ReadLine());

            Console.Write("seconds: ");
            int seconds = int.Parse(Console.ReadLine());

            double totalTimeInSeconds = hours * 3600 + minutes * 60 + seconds;

            double speedInMetersPerSecond = distanceInMeters / totalTimeInSeconds;

            double speedInKilometersPerHour = (distanceInMeters / 1000) / (totalTimeInSeconds / 3600);

            double speedInMilesPerHour = (distanceInMeters / 1609) / (totalTimeInSeconds / 3600);

            Console.WriteLine($"Speed in meters/second is {speedInMetersPerSecond:F8}");
            Console.WriteLine($"Speed in km/h is {speedInKilometersPerHour:F8}");
            Console.WriteLine($"Speed in miles/h is {speedInMilesPerHour:F8}");
        }
    }
    }