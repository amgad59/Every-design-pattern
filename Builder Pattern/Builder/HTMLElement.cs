using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern.Builder
{
    public class HTMLElement
    {
        public string Name, Text;
        public List<HTMLElement> Elements = new List<HTMLElement>();
        private const int indent = 2;
        public HTMLElement()
        {
            
        }
        public HTMLElement(string Name,string Text)
        {
            this.Name = Name;
            this.Text = Text;
        }

        public string ToStringImpl(int indentSize)
        {
            StringBuilder sb = new StringBuilder();
            var i = new string(' ', indent * indentSize);
            sb.Append($"{i}<{Name}>\n");
            if (!string.IsNullOrWhiteSpace(Text))
            {
                sb.Append(new string(' ', indentSize * (indent + 1)));
                sb.Append(Text);
                sb.Append("\n");
            }
            foreach (var e in Elements)
                sb.Append(e.ToStringImpl(indent + 1));
            sb.Append($"{i}</{Name}>\n");
            return sb.ToString();
        }

        public override string ToString()
        {
            return ToStringImpl(0);
        }
    }
}
