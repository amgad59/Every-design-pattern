using Factory_Pattern.Factory_Pattern_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern.Factory_Pattern_2
{
    public class Rectangle : Shape
    {
        public void draw()
        {
            Console.WriteLine("drawing Rectangle");
        }
    }
}
