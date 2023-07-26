using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_Of_Responsibility.Chain_of_Responsibility_Broker_chain
{
    public class Game
    {
        public EventHandler<Query> Queries;
        public void PerformQuery(object sender,Query q)
        {
            Queries?.Invoke(sender, q);
        }
    }
}
