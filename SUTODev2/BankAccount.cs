using System;
using System.Collections.Generic;
using System.Text;

namespace SUTODev2
{
    public interface ILog
    {
        void Write(string msg);
    }
    public class BankAccount
    {
        private ILog log;

        public BankAccount(ILog log)
        {
            this.log = log;
        }

        public decimal Balance { get; set; }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
            }
            else
            {
                log.Write($"Bad amount {amount}");
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= Balance)
                Balance -= amount;
            else
            {
                log.Write($"Bad amount {amount}");
            }
        }
    }
}
