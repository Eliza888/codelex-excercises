using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7
{
    class SavingsAccount
    {
        private double balance;
        private double annualInterestRate;

        public SavingsAccount(double startingBalance)
        {
            balance = startingBalance;
        }

        public void MakeWithdrawal(double amount)
        {
            balance -= amount;
        }

        public void MakeDeposit(double amount)
        {
            balance += amount;
        }

        public void CalculateMonthlyInterest()
        {
            double monthlyInterestRate = annualInterestRate / 12.0;
            double interestEarned = balance * monthlyInterestRate;
            balance += interestEarned;
        }

        public double GetBalance()
        {
            return balance;
        }

        public void SetAnnualInterestRate(double rate)
        {
            annualInterestRate = rate;
        }
    }
}