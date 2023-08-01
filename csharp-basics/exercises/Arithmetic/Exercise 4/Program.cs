namespace Exercise_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int product = 1;

            for (int i = 1; i <= 10; i++)
            {
                product *= i;
            }
            Console.WriteLine(product);
        }
    }
}