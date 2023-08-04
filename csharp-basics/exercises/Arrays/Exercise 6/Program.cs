namespace Exercise_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[10];
            int[] array2 = new int[10];

            Random random = new Random();
            
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = random.Next(1, 101);
            }

            for (int i = 0; i < array1.Length; i++)
            {
                array2[i] = array1[i];
            }

            for (int i = 0; i < array1.Length; i++)
            {
                if (i == array1.Length - 1)
                {
                    array1[i] = -7;
                    break;
                }
            }

            Console.Write("Array 1: ");
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write(array1[i] + " ");
            }
            Console.WriteLine();

            Console.Write("Array 2: ");
            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write(array2[i] + " ");
            }
            Console.WriteLine();
        }
    }
}