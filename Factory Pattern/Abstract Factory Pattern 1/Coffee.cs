using Factory_Pattern.Abstract_Factory_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern.Abstract_Factory_Pattern
{
    public class Coffee : IHotDrink
    {
        public void Consume()
        {
            Console.WriteLine("consuming coffee");
        }
    }
}
