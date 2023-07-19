using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SOLID.D_in_SOLID.SD;

namespace SOLID.D_in_SOLID
{
    public class RelationShips : IRelationShip
    {
        private List<(Person,RelationShip,Person)> relations = new List<(Person, RelationShip, Person)> ();

        public void AddParentAndChild(Person parent, Person child)
        {
            relations.Add((parent, RelationShip.parent, child));
            relations.Add((child, RelationShip.child, parent));
        }
        public IEnumerable<Person> FindAllChildrenOf(string name)
        {
            return relations.Where(x => x.Item1.Name == name 
            && x.Item2 == RelationShip.parent)
                .Select(x => x.Item3);
        }
    }
}
