using System;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount benben = new BankAccount("Benson", 17.25m);
            Console.WriteLine(benben.ShowUserNameAndBalance());

            BankAccount negativeBenben = new BankAccount("Benson", -17.5m);
            Console.WriteLine(negativeBenben.ShowUserNameAndBalance());
        }
    }
}