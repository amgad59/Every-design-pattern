using Mediator_Pattern.Mediator_Pattern_2.PlayerEvents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Pattern.Mediator_Pattern_2.Characters
{
    public class Referee : Actor
    {
        public Referee(EventBroker eventBroker) : base(eventBroker)
        {
            Broker.OfType<PlayerScoredEvent>()
                .Subscribe(p =>
                {
                    Console.WriteLine($"{p.Name} scored his {p.GoalsScored} goal");
                });
            Broker.OfType<PlayerSentOffEvent>()
                .Subscribe(p =>
                {
                    Console.WriteLine($"{p.Name} was sent off due to {p.Reason}");
                });
        }
    }
}
