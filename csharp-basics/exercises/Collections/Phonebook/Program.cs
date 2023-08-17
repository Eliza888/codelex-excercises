using System;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneDirectory phoneDirectory = new PhoneDirectory();

            phoneDirectory.PutNumber("Alice", "54625676");
            phoneDirectory.PutNumber("John", "65786573");

            string aliceNumber = phoneDirectory.GetNumber("Alice");
            string bobNumber = phoneDirectory.GetNumber("John");

            Console.WriteLine("Alices number: " + aliceNumber);
            Console.WriteLine("Johns number: " + bobNumber);
        }
    }
}