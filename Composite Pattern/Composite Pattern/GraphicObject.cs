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
        private Lazy<List<GraphicObject>> graphicObjects = new Lazy<List<GraphicObject>>();
        public List<GraphicObject> Children => graphicObjects.Value;
        public void Print(StringBuilder sb, int depth)
        {
            sb.Append(new string('*',depth))
              .Append(string.IsNullOrEmpty(Color) ? string.Empty : Color)
              .AppendLine($"{Name}");
            foreach(var child in Children)
                child.Print(sb, depth+1);
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            Print(sb, 0);
            return sb.ToString();
        }
    }
}
