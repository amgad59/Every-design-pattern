using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_Pattern.Memento_Pattern
{
    public class Memento
    {
        public int Balance { get; }
        public Memento(int Balance) {
            this.Balance = Balance;
        }
    }
}
