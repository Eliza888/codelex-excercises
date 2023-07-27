namespace Exercise_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a text:");
            string input = Console.ReadLine();

            int countUppercase = 0;
            foreach (char character in input)
            {
                if (char.IsUpper(character))
                {
                    countUppercase++;
                }
            }

            Console.WriteLine("Uppercase letters: " + countUppercase);
        }
    }
}