using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Pattern.State_Pattern_1_Classic_Implementation
{
    public class OffState : State
    {
        public OffState() {
            Console.WriteLine("Light is turned off");
        }
        public override void On(Switch sw)
        {
            Console.WriteLine("Turning light off");
            sw.State = new OnState();
        }
    }
}
