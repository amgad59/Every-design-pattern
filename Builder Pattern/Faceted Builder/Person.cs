using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern.Faceted_Builder
{
    public class Person
    {
        
        public string StreetAddress, City;

        public string Position, CompanyName;
        public int Income;

        public override string ToString()
        {
            return $"{Position},{CompanyName},{Income},{StreetAddress},{City}";
        }
    }
}
