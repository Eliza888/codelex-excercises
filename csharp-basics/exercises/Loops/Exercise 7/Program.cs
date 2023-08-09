namespace Exercise_7
{
    class Piglet
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Piglet! Answer with y or yes and n or no.");

            int totalScore = 0;
            bool gameOver = false;

            while (!gameOver)
            {
                int roll = RollDice();
                Console.WriteLine($"You rolled a {roll}!");

                if (roll == 1)
                {
                    Console.WriteLine("You got 0 points.");
                    gameOver = true;
                }
                else
                {
                    totalScore += roll;
                    Console.Write("Roll again? ");
                    string choice = Console.ReadLine();
                    if (choice.ToLower() != "y" && choice.ToLower() != "yes")
                    {
                        Console.WriteLine($"You got {totalScore} points.");
                        gameOver = true;
                    }
                }
            }
        }

        static int RollDice()
        {
            Random random = new Random();
            return random.Next(1, 7);
        }
    }
}