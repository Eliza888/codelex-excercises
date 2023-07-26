namespace Exercise_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter minutes: ");
            int minutes = int.Parse(Console.ReadLine());

            const int minutesInDay = 24 * 60;
            const int minutesInYear = 365 * minutesInDay;

            int years = minutes / minutesInYear;
            int remainingMinutes = minutes % minutesInYear;
            int days = remainingMinutes / minutesInDay;

            Console.WriteLine($"{minutes} minutes is {years} years and {days} days.");
        }
    }
}