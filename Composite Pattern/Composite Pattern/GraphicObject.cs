using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Pattern.Composite_Pattern
{
    public class GraphicObject
    {
        public virtual string Name { get; set; } = "Group";
        public string Color;
    }
}
