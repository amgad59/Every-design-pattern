using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern.Fluent_Builder_with_Recursive_Generics
{
    public abstract class PersonBuilder
    {
        protected Person person = new Person();
        public Person build()
        {
            return person;
        }
    }
}
