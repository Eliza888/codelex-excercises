namespace Exercise_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Calculator");
            Console.WriteLine("Enter the first number: ");
            double number1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the operator (+, -, *, or /): ");
            char operation = char.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            double number2 = double.Parse(Console.ReadLine());

            double result;
            
            switch (operation)
            {
                case '+':
                    result = number1 + number2;
                    break;
                case '-':
                    result = number1 - number2;
                    break;
                case '*':
                    result = number1 * number2;
                    break;
                case '/':
                    result = number2 != 0 ? number1 / number2 : double.NaN;
                    break;
                default:
                    Console.WriteLine("Invalid operator. Please enter a valid operator (+, -, *, or /).");
                    return;
            }

            Console.WriteLine($"Result: {result}");
        }
    }
}