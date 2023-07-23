using Decorator_Pattern.Decorator_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern.Decorator_Pattern
{
    public class ColoredShape : IShape
    {
        private IShape shape;
        private string Color;
        public ColoredShape(IShape shape,string Color) {
            this.shape = shape;
            this.Color = Color;
        }
        public string AsString()
        {
            return $"{shape.AsString()} has the color {Color}";
        }
    }
}
