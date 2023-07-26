using Chain_Of_Responsibility.Chain_of_Responsibility_Broker_chain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_Of_Responsibility.Chain_of_Responsibility_Broker_chain
{
    public class Creature
    {
        public string Name;
        private int attack, defense;
        public Game game;
        public Creature(Game game,string name, int Attack,int Defense) {
            Name = name;
            attack = Attack;
            defense = Defense;
            this.game = game;
        }
        public int Attack
        {
            get
            {
                var q =new Query(Name,Query.Argument.Attack,attack);
                game.PerformQuery(this,q);
                return q.Value;
            }
        }
        public int Defense
        {
            get
            {
                var q =new Query(Name,Query.Argument.Defense,defense);
                game.PerformQuery(this,q);
                return q.Value;
            }
        }
        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Attack)}: {Attack}, {nameof(Defense)}: {Defense}";
        }
    }
}
