using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern.Abstract_Factory_Pattern_2
{
    public class FactoryBuilder
    {
        public static AbstractFactory getFactory(string factoryName) {
            if (factoryName.ToLower() == "normal")
                return new ShapeFactory();
            else if (factoryName.ToLower() == "rounded")
                return new RoundedShapeFactory();
            else
                throw new ArgumentException();
        }
    }
}
