using System;

namespace SadFor
{
    class Program
    {
        private static void Main(string[] args)
        {
            Test1();
        }

        private static void Test1()
        {

            for (int i = 0; i < 10; i++)
            {
                double j = i * i;
                if (Math.Sqrt(j) > 2.5)
                {
                    Console.WriteLine(j);
                }
            }
        }
    }
}