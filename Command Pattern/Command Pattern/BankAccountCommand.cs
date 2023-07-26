using Command_Pattern.Command_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern.Command_Pattern
{
    public class BankAccountCommand : ICommand
    {
        public enum Action
        {
            Deposit, Withdraw
        }
        private BankAccount bankAccount;
        private Action action;
        private int amount;
        public BankAccountCommand(BankAccount bankAccount,Action action,int amount)
        {
            this.bankAccount = bankAccount;
            this.action = action;
            this.amount = amount;
        }

        public void Call()
        {
            switch(action)
            {
                case Action.Deposit:
                    bankAccount.Deposit(amount);
                    Success = true;
                    break;
                case Action.Withdraw:
                    Success = bankAccount.Withdraw(amount);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        public void Undo()
        {
            if (!Success)
                return;
            switch (action)
            {
                case Action.Deposit:
                    bankAccount.Withdraw(amount);
                    break;
                case Action.Withdraw:
                    bankAccount.Deposit(amount);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        public bool Success
        {
            get;set;
        }

    }
}
