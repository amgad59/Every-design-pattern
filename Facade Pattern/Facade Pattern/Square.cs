using Facade_Pattern.Facade_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern.Facade_Pattern
{
    public class Square : Shape
    {
        public void draw()
        {
            Console.WriteLine("Drawing Square");
        }
    }
}
