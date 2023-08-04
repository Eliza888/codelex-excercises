namespace Exercise_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
                int[][] arrays = new int[][] {
                new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15 },
                new int[] { 92, 6, 73, -77, 81, -90, 99, 8, -85, 34 },
                new int[] { 91, -4, 80, -73, -28 },
                new int[] { }
            };

            foreach (int[] numbers in arrays)
            {
                int positiveCount = 0;
                int negativeSum = 0;

                foreach (int num in numbers)
                {
                    if (num > 0)
                    {
                        positiveCount++;
                    }
                    else if (num < 0)
                    {
                        negativeSum += num;
                    }
                }

                Console.WriteLine($"Positive Count: {positiveCount}, Negative Sum: {negativeSum}");
            }
        }
    }
}