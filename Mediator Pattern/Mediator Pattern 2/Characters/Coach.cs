using Mediator_Pattern.Mediator_Pattern_2.PlayerEvents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Pattern.Mediator_Pattern_2.Characters
{
    public class Coach : Actor
    {
        public Coach(EventBroker eventBroker) : base(eventBroker)
        {
            Broker.OfType<PlayerScoredEvent>()
                .Subscribe(ps =>
                {
                    if (ps.GoalsScored < 3)
                    {
                        Console.WriteLine($"Well Done {ps.Name}");
                    }
                });
            Broker.OfType<PlayerSentOffEvent>()
                .Subscribe(ps =>
                {
                    if (ps.Reason == "Violence")
                    {
                        Console.WriteLine($"why would you do that {ps.Name}");
                    }
                });
        }

    }
}
