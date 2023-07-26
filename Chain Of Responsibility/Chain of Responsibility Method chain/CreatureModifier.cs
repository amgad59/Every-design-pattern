using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_Of_Responsibility.Chain_of_Responsibility_Method_chain
{
    public class CreatureModifier
    {
        public Creature creature;
        public CreatureModifier next;
        public CreatureModifier(Creature creature)
        {
            this.creature = creature;
        }
        public void Add(CreatureModifier cm)
        {
            if(next != null)
                next.Add(cm);
            else 
                next = cm;
        }
        public virtual void Handle() => next?.Handle();

    }
}
