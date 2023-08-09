namespace Exercise_6
{
    class FizzBuzz
    {
        static void RunFizzBuzz(int maxValue)
        {
            for (int i = 1; i <= maxValue; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write("FizzBuzz ");
                }
                else if (i % 3 == 0)
                {
                    Console.Write("Fizz ");
                }
                else if (i % 5 == 0)
                {
                    Console.Write("Buzz ");
                }
                else
                {
                    Console.Write(i + " ");
                }

                if (i % 20 == 0)
                {
                    Console.WriteLine();
                }
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Max value? ");
            int maxValue = int.Parse(Console.ReadLine());

            RunFizzBuzz(maxValue);
        }
    }
}