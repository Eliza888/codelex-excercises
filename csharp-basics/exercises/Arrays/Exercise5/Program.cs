using System;

namespace Exercise5
{
    class Program
    {
        private static void Main(string[] args)
        {
            int[] myArray = { 25, 14, 56, 15, 36, 56, 77, 18, 29, 49 };

            var indexOfElement36 = -1;
            var indexOfElement29 = -1;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] == 36)
                {
                    indexOfElement36 = i;
                }
                else if (myArray[i] == 29)
                {
                    indexOfElement29 = i;
                }

                if (indexOfElement36 != -1 && indexOfElement29 != -1)
                {
                    break;
                }
            }

            Console.WriteLine("Index position of 36 is: " + indexOfElement36);
            Console.WriteLine("Index position of 29 is: " + indexOfElement29);
        }
    }
}