using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.D_in_SOLID
{
    public interface IRelationShip
    {
        IEnumerable<Person> FindAllChildrenOf(string name);
    }
}
