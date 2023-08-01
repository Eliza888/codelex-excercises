namespace Exercise_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text (case insensitive): ");
            string input = Console.ReadLine().ToLower();

            if (!string.IsNullOrEmpty(input))
            {
                input = input.ToLower();

                Console.WriteLine("Using Nested If: " + ConvertToDigitsWithNestedIf(input));
                Console.WriteLine("Using Switch-Case-Default: " + ConvertToDigitsWithSwitchCase(input));
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter some text.");
            }
        }
        public static string ConvertToDigitsWithNestedIf(string input)
        {
            string result = "";
            foreach (char ch in input)
            {
                if (ch >= 'a' && ch <= 'c')
                    result += "2";
                else if (ch >= 'd' && ch <= 'f')
                    result += "3";
                else if (ch >= 'g' && ch <= 'i')
                    result += "4";
                else if (ch >= 'j' && ch <= 'l')
                    result += "5";
                else if (ch >= 'm' && ch <= 'o')
                    result += "6";
                else if (ch >= 'p' && ch <= 's')
                    result += "7";
                else if (ch >= 't' && ch <= 'v')
                    result += "8";
                else if (ch >= 'w' && ch <= 'z')
                    result += "9";
                else
                    result += ch;
            }
            return result;
        }
        public static string ConvertToDigitsWithSwitchCase(string input)
        {
            string result = "";
            foreach (char ch in input)
            {
                switch (ch)
                {
                    case 'a':
                    case 'b':
                    case 'c':
                        result += "2";
                        break;
                    case 'd':
                    case 'e':
                    case 'f':
                        result += "3";
                        break;
                    case 'g':
                    case 'h':
                    case 'i':
                        result += "4";
                        break;
                    case 'j':
                    case 'k':
                    case 'l':
                        result += "5";
                        break;
                    case 'm':
                    case 'n':
                    case 'o':
                        result += "6";
                        break;
                    case 'p':
                    case 'q':
                    case 'r':
                    case 's':
                        result += "7";
                        break;
                    case 't':
                    case 'u':
                    case 'v':
                        result += "8";
                        break;
                    case 'w':
                    case 'x':
                    case 'y':
                    case 'z':
                        result += "9";
                        break;
                    default:
                        result += ch;
                        break;
                }
            }
            return result;
        }
    }
}