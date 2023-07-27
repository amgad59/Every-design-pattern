using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern.Observer_Pattern_2
{
    public class Observant : IObserver<Event>
    {
        public void TestFunction()
        {
            var person = new Person();
            IDisposable sub = person.Subscribe(this);
            person.CatchACold();
        }
        public void OnCompleted()
        {
        }

        public void OnError(Exception error)
        {
        }

        public void OnNext(Event value)
        {

            if(value is FallsIllEvent args){
                Console.WriteLine($"someone is ill at {args.Address}");
            }
        }
    }
}
