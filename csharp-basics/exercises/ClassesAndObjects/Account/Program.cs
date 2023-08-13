using System;

namespace Account
{
    class Program
    {
        static void Main(string[] args)
        {
            Account firstAccount = new Account("First Account", 100.0);
            firstAccount.Deposit(20.0);
            Console.WriteLine(firstAccount);

            Account mattAccount = new Account("Matt's account", 1000.0);
            Account myAccount = new Account("My account", 0.0);

            mattAccount.Withdrawal(100.0);
            myAccount.Deposit(100.0);

            Console.WriteLine(mattAccount);
            Console.WriteLine(myAccount);

            Account accountA = new Account("A", 100.0);
            Account accountB = new Account("B", 0.0);
            Account accountC = new Account("C", 0.0);

            Console.WriteLine("Before transfers:");
            Console.WriteLine(accountA);
            Console.WriteLine(accountB);
            Console.WriteLine(accountC);

            Account.Transfer(accountA, accountB, 50.0);
            Account.Transfer(accountB, accountC, 25.0);

            Console.WriteLine("After transfers:");
            Console.WriteLine(accountA);
            Console.WriteLine(accountB);
            Console.WriteLine(accountC);
        }
    }
}