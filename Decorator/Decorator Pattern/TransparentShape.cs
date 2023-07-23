using Decorator_Pattern.Decorator_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern.Decorator_Pattern
{
    public class TransparentShape : IShape
    {
        private IShape shape;
        private float transparency;
        public TransparentShape(IShape shape,float transparency)
        {
            this.shape = shape;
            this.transparency = transparency;
        }
        public string AsString()
        {
            return $"{shape.AsString()} has {transparency * 100.0f} transparency";
        }
    }
}
