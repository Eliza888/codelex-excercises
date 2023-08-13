namespace Account
{
    class Account
    {
        private string accountName;
        private double balance;

        public Account(string accountName, double initialBalance)
        {
            this.accountName = accountName;
            this.balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }
        }

        public bool Withdrawal(double amount)
        {
            if (amount > 0 && balance >= amount)
            {
                balance -= amount;
                return true;
            }
            return false;
        }

        public double Balance()
        {
            return balance;
        }

        public override string ToString()
        {
            return $"{accountName} balance: {balance:F2}";
        }

        public static void Transfer(Account from, Account to, double howMuch)
        {
            from.Withdrawal(howMuch);
            to.Deposit(howMuch);
        }
    }
}