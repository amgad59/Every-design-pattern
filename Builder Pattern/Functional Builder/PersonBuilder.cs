using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern.Functional_Builder
{
    public sealed class PersonBuilder
    {
        public readonly List<Action<Person>> actions = new List<Action<Person>>();

        public PersonBuilder Called(string name)
        {
            actions.Add(p => { p.name = name; });
            return this;
        }
        public Person build()
        {
            var p = new Person();
            actions.ForEach(a => a(p));
            return p;
        }
    }
}
