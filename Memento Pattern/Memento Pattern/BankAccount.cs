using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_Pattern.Memento_Pattern
{
    public class BankAccount
    {
        private int Balance;
        private List<Memento> Changes = new List<Memento>();
        private int Current;
        public BankAccount(int Balance)
        {
            this.Balance = Balance;
            Changes.Add(new Memento(Balance));
        }
        public void Deposit(int amount)
        {
            Balance += amount;
            var m = new Memento(Balance);
            Changes.Add(m);
            Current++;
        }
        public void Withdraw(int amount)
        {
            Balance -= amount;
            var m = new Memento(Balance);
            Changes.Add(m);
            Current++;
        }
        public void Restore(Memento m)
        {
            if(m != null)
            {
                Balance = m.Balance;
                Changes.Add(m);
                Current = Changes.Count - 1;
            }
        }
        public Memento Undo()
        {
            if(Current > 0)
            {
                var m = Changes[--Current];
                Balance = m.Balance;
                return m;
            }
            return null;
        }
        public Memento Redo()
        {
            if(Current+1 < Changes.Count)
            {
                var m = Changes[++Current];
                Balance = m.Balance;
                return m;
            }
            return null;
        }
        public override string ToString()
        {
            return $"balacne: {Balance}";
        }

    }
}
