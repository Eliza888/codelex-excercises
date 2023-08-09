namespace Exercise_10
{
    class NumberSquare
    {
        static void Main(string[] args)
        {
            Console.Write("Min? ");
            int min = int.Parse(Console.ReadLine());

            Console.Write("Max? ");
            int max = int.Parse(Console.ReadLine());

            int value = max - min + 1;

            for (int i = 0; i < value; i++)
            {
                for (int j = 0; j < value; j++)
                {
                    int num = (min + i + j - 1) % value + min;
                    Console.Write(num);
                }
                Console.WriteLine();
            }
        }
    }
}