using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_Of_Responsibility.Chain_of_Responsibility_Method_chain
{
    public class IncreaseDefenseModifier : CreatureModifier
    {
        public IncreaseDefenseModifier(Creature creature) : base(creature)
        {
        }
        public override void Handle()
        {
            Console.WriteLine($"increasing {creature.Name}'s defense");
            creature.Defense += 5;
            base.Handle();
        }
    }
}
