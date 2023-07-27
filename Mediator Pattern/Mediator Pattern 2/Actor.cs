using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Pattern.Mediator_Pattern_2
{
    public class Actor
    {
        protected EventBroker Broker;
        public Actor(EventBroker eventBroker)
        {
            Broker = eventBroker;
        }
    }
}
