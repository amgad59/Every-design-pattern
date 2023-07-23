using Decorator_Pattern.Decorator_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern.Decorator_Pattern
{
    public class Square : IShape
    {
        private float side;
        public Square(float side)
        {
            this.side = side;
        }
        public string AsString()
        {
            return $"A square of side {side}";
        }
    }
}
