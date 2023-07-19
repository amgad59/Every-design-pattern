using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern.Faceted_Builder
{
    public class PersonAddressBuilder : PersonBuilder
    {
        public PersonAddressBuilder(Person person) { this.person = person; }
        public PersonAddressBuilder At(string address)
        {
            person.StreetAddress = address;
            return this;
        }
        public PersonAddressBuilder City(string city)
        {
            person.City = city;
            return this;
        }
    }
}
