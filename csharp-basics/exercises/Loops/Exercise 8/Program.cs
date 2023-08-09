namespace Exercise_8
{
    class AsciiFigure
    {
        static int size = 7;

        public void Draw()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size * 2 - 2 - 2 * i; j++)
                {
                    Console.Write('/');
                }
                for (int j = 0; j < 4 * i; j++)
                {
                    Console.Write('*');
                }
                for (int j = 0; j < size * 2 - 2 - 2 * i; j++)
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