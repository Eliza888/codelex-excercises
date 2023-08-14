namespace Exercise_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How much money is in the account?: ");
            double startingBalance = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the annual interest rate: ");
            double annualInterestRate = Convert.ToDouble(Console.ReadLine());

            Console.Write("How long has the account been opened? ");
            int months = Convert.ToInt32(Console.ReadLine());

            SavingsAccount savingsAccount = new SavingsAccount(startingBalance);
            savingsAccount.SetAnnualInterestRate(annualInterestRate);

            double totalDeposits = 0;
            double totalWithdrawals = 0;

            for (int i = 1; i <= months; i++)
            {
                Console.Write($"Enter amount deposited for month {i}: ");
                double depositAmount = Convert.ToDouble(Console.ReadLine());
                savingsAccount.MakeDeposit(depositAmount);
                totalDeposits += depositAmount;

                Console.Write($"Enter amount withdrawn for {i}: ");
                double withdrawalAmount = Convert.ToDouble(Console.ReadLine());
                savingsAccount.MakeWithdrawal(withdrawalAmount);
                totalWithdrawals += withdrawalAmount;

                savingsAccount.CalculateMonthlyInterest();
            }

            double totalInterestEarned = savingsAccount.GetBalance() - (startingBalance + totalDeposits - totalWithdrawals);

            Console.WriteLine($"Total deposited: ${totalDeposits.ToString("0.00")}");
            Console.WriteLine($"Total withdrawn: ${totalWithdrawals.ToString("0.00")}");
            Console.WriteLine($"Interest earned: ${totalInterestEarned.ToString("0.00")}");
            Console.WriteLine($"Ending balance: ${savingsAccount.GetBalance().ToString("0.00")}");
        }
    }
}