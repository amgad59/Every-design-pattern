using Null_Object_Pattern.Null_Object_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Null_Object_Pattern.Null_Object_Pattern
{
    public class BankAccount
    {
        public ILog log;
        public int balance;
        public BankAccount(ILog log)
        {
            this.log = log;
        }
        public void Deposit(int amount)
        {
            balance += amount;
            log.Log($"current balance {balance}");
        }
        public void Withdraw(int amount)
        {
            if(balance-amount > 0)
            {
            balance += amount;
            log.Log($"current balance {balance}");

            }
            else
            {
                log.Warn("Not enough balance");
            }
        }
    }
}
