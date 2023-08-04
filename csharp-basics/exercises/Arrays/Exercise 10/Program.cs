namespace Exercise_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
                int[][] arrays = new int[][] {
                new int[] { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, -13, -14, -15, -16, -17 },
                new int[] { 76, 12, 51, -71, 67, -34, 55, 56, -80, 26 },
                new int[] { 91, -7, 70, -55, -56 },
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