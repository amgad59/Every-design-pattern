using Factory_Pattern.Abstract_Factory_Pattern_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern.Abstract_Factory_Pattern_2
{
    public abstract class AbstractFactory
    {
        public abstract Shape GetShape(string ShapeType);
    }
}
