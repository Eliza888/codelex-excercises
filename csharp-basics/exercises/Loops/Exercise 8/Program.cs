namespace Exercise_8
{
    class AsciiFigure
    {
        static int SIZE = 55;

        public void Draw()
        {
            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE * 2 - 2 - 2 * i; j++)
                {
                    Console.Write('/');
                }
                for (int j = 0; j < 4 * i; j++)
                {
                    Console.Write('*');
                }
                for (int j = 0; j < SIZE * 2 - 2 - 2 * i; j++)
                {
                    Console.Write('\\');
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            AsciiFigure figure = new AsciiFigure();
            figure.Draw();
        }
    }
}