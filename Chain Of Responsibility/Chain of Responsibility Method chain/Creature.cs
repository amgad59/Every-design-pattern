using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_Of_Responsibility.Chain_of_Responsibility_Method_chain
{
    public class Creature
    {
        public string Name;
        public int Attack, Defense;
        public Creature(string name, int Attack,int Defense) {
            Name = name;
            this.Attack = Attack;
            this.Defense = Defense;
        }
        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Attack)}: {Attack}, {nameof(Defense)}: {Defense}";
        }
    }
}
