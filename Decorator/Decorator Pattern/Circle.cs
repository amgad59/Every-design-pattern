using Decorator_Pattern.Decorator_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern.Decorator_Pattern
{
    public class Circle : IShape
    {
        private float Radius;
        public Circle(float Radius) { 
            this.Radius = Radius;
        }
        public void Resize(float factor)
        {
            Radius *= factor;
        }
        public string AsString()
        {
            return $"A circle of radius {Radius}";
        }
    }
}
