using System.IO;

namespace Exercise_9
{
    class RollTwoDice
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Console.Write("Desired sum: ");
            int desiredSum = int.Parse(Console.ReadLine());

            int rollCount = 0;
            while (true)
            {
                int dice1 = random.Next(1, 7);
                int dice2 = random.Next(1, 7);
                int sum = dice1 + dice2;

                rollCount++;

                Console.WriteLine($"{dice1} and {dice2} = {sum}");

                if (sum == desiredSum)
                {
                    Console.WriteLine($"It took {rollCount} rolls to get the desired sum.");
                    break;
                }
            }
        }
    }
}