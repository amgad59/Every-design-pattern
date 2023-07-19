using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Builder_Pattern.Fluent_Builder_with_Recursive_Generics
{
    public class Person
    {
        public string Name;
        public string Position;
        public static Builder New => new Builder();
        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Position)}: {Position}";
        }
    }
}
