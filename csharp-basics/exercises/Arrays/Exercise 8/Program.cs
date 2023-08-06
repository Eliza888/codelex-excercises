namespace Exercise_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var words = new List<string>
            {
                "Ephemeral",
                "Luminous",
                "Quixotic",
                "Serendipity",
                "Mellifluous"
            };

            var allowedMisses = 6;
            var missedLetter = string.Empty;
            var word = words[random.Next(words.Count)];
            var wordForDisplay = new string('_', word.Length);

            while (wordForDisplay.Contains('_') && allowedMisses >= 0) 
            {
                Console.WriteLine("Guess the word!");    
                Console.WriteLine($"Word: { wordForDisplay}");
                Console.WriteLine($"Misses possible: 6: ${missedLetter} ");
                Console.WriteLine();
                Console.Write($"Guess: ");
                var input = Console.ReadKey();
                Console.WriteLine();

                char inputChar;
                while (true)
                {
                    var inputKey = Console.ReadKey();
                    inputChar = inputKey.KeyChar;

                    if (char.IsLetter(inputChar))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine(" Please enter a valid letter.");
                    }
                }

                if (word.ToLower().Contains(char.ToLower(input.KeyChar)))
                {
                    for(int i = 0; i < word.Length; i++) 
                    {
                        if (char.ToLower(word[i]) ==char.ToLower(input.KeyChar))
                        {
                                wordForDisplay = wordForDisplay.Substring(0, i) + 
                                word[i] + 
                                wordForDisplay.Substring(i + 1);
                        }
                    }
                }
                else
                {
                    missedLetter += input.KeyChar;
                    allowedMisses--;
                }
                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            }
            Console.Clear();
            Console.WriteLine("Game Over!");
            if (wordForDisplay.Contains('_'))
            {
                Console.WriteLine($"You lost! The word was: {word}");
            }
            else
            {
                Console.WriteLine("Congratulations! You won!");
            }
        }
    }
}