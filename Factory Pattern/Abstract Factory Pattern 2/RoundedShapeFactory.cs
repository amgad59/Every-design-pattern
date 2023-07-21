using Factory_Pattern.Abstract_Factory_Pattern_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern.Abstract_Factory_Pattern_2
{
    public class RoundedShapeFactory : AbstractFactory
    {
        public override Shape GetShape(string ShapeType)
        {
            if (ShapeType.ToLower() == "square")
                return new RoundedSquare();
            else if (ShapeType.ToLower() == "rectangle")
                return new RoundedRectangle();
            else
            {
                throw new ArgumentException();
            }
        }
    }
}
