using Mediator_Pattern.Mediator_Pattern_2.PlayerEvents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Pattern.Mediator_Pattern_2.Characters
{
    public class Player : Actor
    {
        public int GoalsScored { get; set; } = 0;
        public string Name { get; set; } = "Default";
        private IDisposable sub;
        
        public void Score()
        {
            GoalsScored++;
            Broker.Publish(new PlayerScoredEvent { GoalsScored = GoalsScored , Name = Name});
        }
        public void AssaultReferee()
        {
            Broker.Publish(new PlayerSentOffEvent { Reason = "Violence" , Name = Name});
        }
        public Player(EventBroker eventBroker, string name) : base(eventBroker)
        {
            Name = name;
            Broker.OfType<PlayerScoredEvent>()
                .Where(ps => !ps.Name.Equals(name))
                .Subscribe(p =>
                {
                    Console.WriteLine($"{name}: nicely scored {p.Name} its your {p.GoalsScored} goal");
                });
            Broker.OfType<PlayerSentOffEvent>()
                .Subscribe(p =>
                {
                    Console.WriteLine($"{name}: see you later {p.Name}");
                });
        }
    }
}
