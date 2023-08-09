namespace Exercise_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first word:");
            string firstWord = Console.ReadLine();

            Console.WriteLine("Enter second word:");
            string secondWord = Console.ReadLine();

            int dotCount = 30 - (firstWord.Length + secondWord.Length);

            Console.Write(firstWord);
            for (int i = 0; i < dotCount; i++)
            {
                Console.Write(".");
            }
            Console.WriteLine(secondWord);
        }
    }
}