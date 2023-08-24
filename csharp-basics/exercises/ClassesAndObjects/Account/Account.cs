namespace Account
{
    class Account
    {
        private string _accountName;
        private double balance;

        public Account(string accountName, double initialBalance)
        {
            _accountName = accountName;
            balance = initialBalance;
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
            return $"{_accountName} balance: {balance.ToString("0.00")}";
        }
    }
}