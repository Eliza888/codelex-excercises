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
            string formattedBalance;

            if (Balance >= 0)
            {
                int dollars = (int)Balance;
                int cents = (int)((Balance - dollars) * 100);
                formattedBalance = "$" + dollars + "." + (cents < 10 ? "0" + cents : cents.ToString());
            }
            else
            {
                int dollars = (int)(-Balance);
                int cents = (int)((-Balance - dollars) * 100);
                formattedBalance = "$" + dollars + "." + (cents < 10 ? "0" + cents : cents.ToString());
            }

            return Name + ", " + formattedBalance;
        }
    }
}