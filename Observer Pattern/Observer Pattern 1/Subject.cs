using Observer_Pattern.Observer_Pattern_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern.Observer_Pattern_1
{
    public class Subject : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();

        public int state { get; set; }

        public void Attach(IObserver observer)
        {
            Console.WriteLine("attach observer");
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            Console.WriteLine("attach observer");
            observers.Remove(observer);
        }

        public void NotifyAll()
        {
            foreach(var observer in observers)
            {
                observer.Update(this);
            }
        }
        public void ChangeState(int state)
        {
            this.state = state;
            Console.WriteLine($"State changed to {state}");
            NotifyAll();
        }
    }
}
