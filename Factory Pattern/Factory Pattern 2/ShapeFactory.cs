using Factory_Pattern.Factory_Pattern_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern.Factory_Pattern_2
{
    public class ShapeFactory
    {
        public Shape GetShape(string shapeName)
        {
            if(shapeName.ToLower() == "square")
            {
                return new Square();
            }
            else if(shapeName.ToLower() == "circle")
            {
                return new Circle();
            }
            else if(shapeName.ToLower() == "rectangle")
            {
                return new Rectangle();
            }
            else
            {
                throw new ArgumentException();
            }

        }
    }
}
