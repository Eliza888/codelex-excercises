namespace Exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FuelGauge fuelGauge = new FuelGauge();
            Odometer odometer = new Odometer(fuelGauge);

            while (fuelGauge.CurrentFuel < 70)
            {
                fuelGauge.IncrementFuel();
            }

            while (fuelGauge.CurrentFuel > 0)
            {
                Console.WriteLine($"Mileage: {odometer.CurrentMileage} km | Fuel: {fuelGauge.CurrentFuel} liters");
                odometer.IncrementMileage();
            }

            Console.WriteLine("Car has run out of fuel.");
        }
    }
}