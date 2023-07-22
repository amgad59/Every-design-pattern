using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.L_in_SOLID
{
    public class Rectangle
    {
        public virtual int width { get; set; }
        public virtual int height { get; set; }

        public Rectangle()
        {

        }
        public Rectangle(int width,int height)
        {
            this.width = width;
            this.height = height;
        }

        public override string ToString()
        {
            return $"{nameof(width)}: {width}, {nameof(height)}: {height}";
        }
    }
}
