using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Pattern.State_Pattern_1_Classic_Implementation
{
    public abstract class State
    {
        public virtual void On(Switch sw)
        {
            Console.WriteLine("Light is already on");
        }
        public virtual void Off(Switch sw)
        {
            Console.WriteLine("Light is already off");
        }
    }
}
