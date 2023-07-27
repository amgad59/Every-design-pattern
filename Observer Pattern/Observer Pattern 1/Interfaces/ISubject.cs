using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern.Observer_Pattern_1.Interfaces
{
    public interface ISubject
    {
        public int state { get; set; }
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void NotifyAll();
    }
}
