namespace Exercise_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Smoothie s1 = new Smoothie(new string[] { "Banana" });
                Console.WriteLine(string.Join(", ", s1.Ingredients));
                Console.WriteLine($"Cost: £{s1.GetCost():F2}");
                Console.WriteLine($"Price: £{s1.GetPrice():F2}");
                Console.WriteLine($"Name: {s1.GetName()}");

                Smoothie s2 = new Smoothie(new string[] { "Raspberries", "Strawberries", "Blueberries" });
                Console.WriteLine(string.Join(", ", s2.Ingredients));
                Console.WriteLine($"Cost: £{s2.GetCost():F2}");
                Console.WriteLine($"Price: £{s2.GetPrice():F2}");
                Console.WriteLine($"Name: {s2.GetName()}");
            }
        }
    }