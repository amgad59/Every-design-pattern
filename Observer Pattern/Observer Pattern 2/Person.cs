using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern.Observer_Pattern_2
{
    public class Person : IObservable<Event>
    {
        public readonly HashSet<Subscription> subscriptions = new HashSet<Subscription>();
        public IDisposable Subscribe(IObserver<Event> observer)
        {
            var subscription = new Subscription(this,observer);
            subscriptions.Add(subscription);
            return subscription;
        }
        public void CatchACold()
        {
            foreach(var sub in subscriptions)
            {
                sub.Observer.OnNext(new FallsIllEvent { Address = "123 Madinty" });
            }
        }
        public class Subscription : IDisposable
        {
            private Person person;
            public IObserver<Event> Observer;
            public Subscription(Person person, IObserver<Event> observer)
            {
                this.person = person;
                Observer = observer;
            }
            public void Dispose()
            {
                person.subscriptions.Remove(this);
            }
        }
    }
}
