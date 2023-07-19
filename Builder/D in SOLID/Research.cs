using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.D_in_SOLID
{
    public class Research
    {
        public Research(IRelationShip relationShip)
        {
            foreach(var p  in relationShip.FindAllChildrenOf("John"))
            {
                Console.WriteLine($"John has a child called {p.Name}");
            }   
        }
    }
}
