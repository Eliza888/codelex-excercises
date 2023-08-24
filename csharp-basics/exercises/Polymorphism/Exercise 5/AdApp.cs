using Exercise_5;

class AdApp
{
    static void Main(string[] args)
    {
        Program[] programs = new Program[]
        {
            new Hoarding(100, 7, true),
            new NewspaperAd(10, 30),
            new TVCommercial(50, 60, true),
            new Poster(20, 2.5, 100, 0.1)
        };

        foreach (var program in programs)
        {
            string adType = program.GetType().Name;
            double totalCost = program.CalculateCost();

            Console.WriteLine($"{adType} - Total Cost: {totalCost}");
        }
    }
}