namespace Exercise_11
{
    internal class Program
    {
        static string ReverseCase(string input)
        {
            char[] reversed = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                char a = input[i];
                if (char.IsLower(a))
                {
                    reversed[i] = char.ToUpper(a);
                }
                else if (char.IsUpper(a))
                {
                    reversed[i] = char.ToLower(a);
                }
                else
                {
                    reversed[i] = a;
                }
            }

            return new string(reversed);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ReverseCase("A TEXT IN ALL CAPS"));
            Console.WriteLine(ReverseCase("a text in small caps"));
            Console.WriteLine(ReverseCase("A TeXt In RanDoM CapS"));
        }
    }
}