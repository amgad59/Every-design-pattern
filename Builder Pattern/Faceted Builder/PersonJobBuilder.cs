using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern.Faceted_Builder
{
    public class PersonJobBuilder : PersonBuilder
    {
        public PersonJobBuilder(Person person)
        {
            this.person = person;
        }
        public PersonJobBuilder At(string name)
        {
            person.CompanyName = name;
            return this;
        }
        public PersonJobBuilder AsA(string name)
        {
            person.Position = name;
            return this;
        }
        public PersonJobBuilder Earning(int income)
        {
            person.Income = income;
            return this;
        }
    }
}
