using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BankAccount
{
    class BankAccount
    {
        public string Name { get; private set; }
        public decimal Balance { get; private set; }

        public BankAccount(string name, decimal balance)
        {
            Name = name;
            Balance = balance;
        }
        public string ShowUserNameAndBalance()
        {
            int dollars = (int)Math.Abs(Balance);
            int cents = (int)(Math.Abs(Balance) * 100) % 100;
            string balanceFormatted = $"{(Balance >= 0 ? "$" : "$")}{dollars}.{(cents < 10 ? "0" : "")}{cents}";

            return $"{Name}, {balanceFormatted}";
        }
    }
}