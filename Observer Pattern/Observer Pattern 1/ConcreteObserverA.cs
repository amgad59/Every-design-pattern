using Observer_Pattern.Observer_Pattern_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern.Observer_Pattern_1
{
    public class ConcreteObserverA : IObserver
    {
        public string Name;
        public ConcreteObserverA(string name)
        {
            Name = name;
        }
        public void Update(ISubject subject)
        {
            if (subject.state == 0 || subject.state >= 3)
                Console.WriteLine($"{Name} reacted to the event");
        }
    }
}
