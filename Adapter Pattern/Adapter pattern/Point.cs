using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern.Adapter_pattern
{
    public class Point
    {
        public int x,y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public override int GetHashCode()
        {
            return (x*397) ^ y;
        }

        public override string ToString()
        {
            return $"({x}, {y})";
        }
    }
}
