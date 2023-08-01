namespace Exercise_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the day number (0 to 6): ");
            if (int.TryParse(Console.ReadLine(), out int dayNumber))
            {
                string dayNested, daySwitch;
                dayNested = daySwitch = "Not a valid day";

                if (dayNumber >= 0 && dayNumber <= 6)
                {
                    if (dayNumber == 0)
                        dayNested = "Sunday";
                    else if (dayNumber == 1)
                        dayNested = "Monday";
                    else if (dayNumber == 2)
                        dayNested = "Tuesday";
                    else if (dayNumber == 3)
                        dayNested = "Wednesday";
                    else if (dayNumber == 4)
                        dayNested = "Thursday";
                    else if (dayNumber == 5)
                        dayNested = "Friday";
                    else if (dayNumber == 6)
                        dayNested = "Saturday";
                }

                switch (dayNumber)
                {
                    case 0:
                        daySwitch = "Sunday";
                        break;
                    case 1:
                        daySwitch = "Monday";
                        break;
                    case 2:
                        daySwitch = "Tuesday";
                        break;
                    case 3:
                        daySwitch = "Wednesday";
                        break;
                    case 4:
                        daySwitch = "Thursday";
                        break;
                    case 5:
                        daySwitch = "Friday";
                        break;
                    case 6:
                        daySwitch = "Saturday";
                        break;
                }

                Console.WriteLine("Using Nested If: " + dayNested);
                Console.WriteLine("Using Switch-Case-Default: " + daySwitch);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer (0 to 6).");
            }
        }
    }
}