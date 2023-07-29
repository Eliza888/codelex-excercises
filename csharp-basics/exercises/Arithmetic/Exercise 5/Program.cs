namespace Exercise_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number = random.Next(1, 100);

            Console.WriteLine("I'm thinking of a number between 1 and 100. Try to guess it.");
            Console.Write("> ");
            
            int userGuess = int.Parse(Console.ReadLine());
            string message = userGuess == number ? "You guessed it! What are the odds?!?" :
                             userGuess > number ? $"Sorry, you are too high. I was thinking of {number}." :
                             $"Sorry, you are too low. I was thinking of {number}.";
            Console.WriteLine(message);
        }
    }
}