namespace Exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer:");
            int number = int.Parse(Console.ReadLine());

            string result = (number % 2 == 0) ? "Even Number" : "Odd Number";

            Console.WriteLine(result);
            Console.WriteLine("bye!");
        }
    }
}                        