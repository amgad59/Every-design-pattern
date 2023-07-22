using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern.Adapter_pattern
{
    public class LineToPointAdapter : IEnumerable<Point>
    {
        private static int count = 0;
        static Dictionary<int, List<Point>> cache = new Dictionary<int, List<Point>>();
        private int hash;

        public LineToPointAdapter(Line line)
        {
            hash = line.GetHashCode();
            if(cache.ContainsKey(hash))
            {
                return;
            }
            Console.WriteLine($"{++count}:Generating lines for line[{line.Start.x},{line.Start.y}-{line.End.x},{line.End.y}]");
            List<Point> points = new List<Point>();


            int left = Math.Min(line.Start.x, line.End.x);
            int right = Math.Max(line.Start.x, line.End.x);
            int top = Math.Min(line.Start.y, line.End.y);
            int bottom = Math.Max(line.Start.y, line.End.y);
            int dx = right - left;
            int dy = line.End.y - line.Start.y;

            if (dx == 0)
            {
                for (int y = top; y <= bottom; ++y)
                {
                    points.Add(new Point(left, y));
                }
            }
            else if (dy == 0)
            {
                for (int x = left; x <= right; ++x)
                {
                    points.Add(new Point(x, top));
                }
            }
            cache.Add(hash, points);
        }

        public IEnumerator<Point> GetEnumerator()
        {
            return cache[hash].GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
