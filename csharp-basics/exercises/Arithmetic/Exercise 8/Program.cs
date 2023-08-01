namespace Exercise_8
{
    internal class Program
    {
        static void CalculateAndPrintPay(double basePay, int hoursWorked)
        {
            const double minimumWage = 8.00;
            const int maxHoursPerWeek = 60;
            const int regularHours = 40;
            const double overtimeRate = 1.5;

            if (basePay < minimumWage)
            {
                Console.WriteLine($"Error: Pay must be at least ${minimumWage} per hour.");
                return;
            }
            if (hoursWorked > maxHoursPerWeek)
            {
                Console.WriteLine($"Error: Cannot work more than {maxHoursPerWeek} hours.");
                return;
            }
            double regularPay = Math.Min(hoursWorked, regularHours) * basePay;
            double overtimePay = Math.Max(hoursWorked - regularHours, 0) * basePay * overtimeRate;
            double totalPay = regularPay + overtimePay;
            
            Console.WriteLine($"Total pay: ${totalPay}");
        }

        static void Main(string[] args)
        {
            CalculateAndPrintPay(7.50, 35); 
            CalculateAndPrintPay(8.20, 47);  
            CalculateAndPrintPay(10.00, 73); 
        }
    }
}