using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    public class Point
    {
        public double x,y;
        private Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return $"x: {x}, y: {y}";
        }
        public static class Factory
        {
            public static Point getPolarPoint(double x, double y)
            {
                return new Point(x, y);
            }
            public static Point getCartesianPoint(double rho, double pho)
            {
                return new Point(rho * Math.Cos(pho), rho * Math.Sin(pho));
            }
        }
    }
}
