using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccountException.Entities.Exception;

namespace BankAccountException.Entities
{
    class Account
    {
        public int numberaccount { get; set; }
        public string holder { get; set; }
        public double balance { get; set; }
        public double withdrawLimit { get; set; }

        public Account(int numberaccount, string holder, double balance, double withdrawLimit)
        {
            if(numberaccount < 1 || holder == null || balance < 0)
            {
                throw new DomainException("Error! Invalid bank details");
            }

            this.numberaccount = numberaccount;
            this.holder = holder;
            this.balance = balance;
            this.withdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {          
            balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (balance <= 0 || amount > withdrawLimit)
            {
                throw new DomainException("Balance is 0 or amount is bigger than withdraw limit");
            }

            balance -= amount;
        }

        public override string ToString()
        {
            return "\nNew balance: " + balance;
        }
    }
}
