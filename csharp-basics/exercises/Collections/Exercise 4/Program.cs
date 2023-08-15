namespace Exercise_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> uniqueNames = new HashSet<string>();

            Console.WriteLine("Enter names (one per line). Press Enter without typing a name to finish.");
            while (true)
            {
                Console.Write("Enter name: ");
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                    break;

                uniqueNames.Add(input.Trim());
            }

            Console.WriteLine("Unique name list contains: " + string.Join(" ", uniqueNames));
        }
    }
}