using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Pattern.Protection_Pattern
{
    public class Driver
    {
        public int Age { get; set; }
        public Driver(int Age)
        {
            this.Age = Age;   
        }
    }
}
