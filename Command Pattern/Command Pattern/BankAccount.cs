using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern.Command_Pattern.Interfaces
{
    public class BankAccount
    {
        private int balance;
        private int overdraftLimit=-500;
        public BankAccount(int balance = 0)
        {
            this.balance = balance;
        }
        public void Deposit (int amount)
        {
            balance += amount;
            Console.WriteLine($"Deposited ${amount}, balance is now {balance}");
        }
        public bool Withdraw (int amount)
        {
            if(balance - amount > overdraftLimit )
            {
                balance -= amount;
                Console.WriteLine($"withdrew ${amount}, balance is now {balance}");
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return $"Balance: {balance}";
        }
    }
}
