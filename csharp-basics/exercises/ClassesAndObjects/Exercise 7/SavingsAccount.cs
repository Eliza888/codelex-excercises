using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7
{
    class SavingsAccount
    {
        private double _balance;
        private double annualInterestRate;

        public SavingsAccount(double startingBalance)
        {
            _balance = startingBalance;
        }

        public void MakeWithdrawal(double amount)
        {
            _balance -= amount;
        }

        public void MakeDeposit(double amount)
        {
            _balance += amount;
        }

        public void CalculateMonthlyInterest()
        {
            double monthlyInterestRate = annualInterestRate / 12.0;
            double interestEarned = _balance * monthlyInterestRate;
            _balance += interestEarned;
        }

        public double GetBalance()
        {
            return _balance;
        }

        public void SetAnnualInterestRate(double rate)
        {
            annualInterestRate = rate;
        }
    }
}