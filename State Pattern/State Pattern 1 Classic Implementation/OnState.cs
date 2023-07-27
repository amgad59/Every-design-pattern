using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Pattern.State_Pattern_1_Classic_Implementation
{
    public class OnState : State
    {
        public OnState() {
            Console.WriteLine("Light is turned on");
        }
        public override void Off(Switch sw)
        {
            Console.WriteLine("Turning light off");
            sw.State = new OffState();
        }
    }
}
