using Prototype_Pattern.Prototype_Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Pattern
{
    public class Person 
    {
        public string []names;
        public Address address;
        public Person()
        {
            
        }
        public Person(string[] names, Address address)
        {
            this.names = names;
            this.address = address;
        }


        public override string ToString()
        {
            return $"names: {string.Join(',', names)} \nHouse Number:{address.houseNumber}, Address:{address.streetAddress}";
        }
    }
}
