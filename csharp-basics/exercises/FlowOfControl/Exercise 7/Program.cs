namespace Exercise_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock-Paper-Scissors!");
            Console.WriteLine("Enter your move (Rock, Paper, or Scissors): ");
            string playerMove = Console.ReadLine().ToLower();

            Random random = new Random();
            int computerMoveIndex = random.Next(3);
            string[] moves = { "rock", "paper", "scissors" };
            string computerMove = moves[computerMoveIndex];

            Console.WriteLine($"Computer chooses: {computerMove}");

            string result;
            switch (playerMove)
            {
                case "rock":
                    result = computerMove == "scissors" ? "You win!" : computerMove == "paper" ? "Computer wins!" : "It's a tie!";
                    break;
                case "paper":
                    result = computerMove == "rock" ? "You win!" : computerMove == "scissors" ? "Computer wins!" : "It's a tie!";
                    break;
                case "scissors":
                    result = computerMove == "paper" ? "You win!" : computerMove == "rock" ? "Computer wins!" : "It's a tie!";
                    break;
                default:
                    result = "Invalid move. Please choose Rock, Paper, or Scissors.";
                    break;
            }

            Console.WriteLine(result);
        }
    }
}