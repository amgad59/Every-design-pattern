using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.L_in_SOLID
{
    public class Square : Rectangle
    {
        public override int width { set => base.width = base.height = value; }
        public override int height { set => base.height = base.width = value; }
    }
}
