using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern.Adapter_pattern
{
    public class Line
    {
        public Point Start, End;
        public Line(Point Start, Point End)
        {
            this.Start = Start;
            this.End = End;
        }
        public override int GetHashCode()
        {
            return (Start.GetHashCode() * 397) ^ End.GetHashCode();
        }
    }
}
