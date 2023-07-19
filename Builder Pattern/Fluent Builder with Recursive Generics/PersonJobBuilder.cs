using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern.Fluent_Builder_with_Recursive_Generics
{
    public class PersonJobBuilder<T> : PersonInfoBuilder<PersonJobBuilder<T>> where T : PersonJobBuilder<T>
    {
        public T WorkAs(string job)
        {
            person.Position = job;
            return (T) this;
        }
    }
}
