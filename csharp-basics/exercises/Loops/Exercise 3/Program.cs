namespace Exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int numberOfNumbers = 20;
            int[] randomNumbers = new int[numberOfNumbers];
            Random random = new Random();

            for (int i = 0; i < numberOfNumbers; i++)
            {
                randomNumbers[i] = random.Next(1, 101);
            }

            Console.WriteLine("Enter the position (1-20) of the random number you want to know:");
            int position = int.Parse(Console.ReadLine());

            if (position >= 1 && position <= numberOfNumbers)
            {
                int selectedNumber = randomNumbers[position - 1];
                Console.WriteLine($"The number at position {position} is: {selectedNumber}");
            }
            else
            {
                Console.WriteLine("Invalid. Please enter a position between 1 and 20.");
            }

            Console.WriteLine("The 20 random numbers were: ");
            foreach (int number in randomNumbers)
            {
                Console.Write(number + " ");
            }

            Console.ReadKey();
        }
    }
}