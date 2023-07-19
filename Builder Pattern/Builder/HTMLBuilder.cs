using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern.Builder
{
    public class HTMLBuilder
    {
        private readonly string rootName;
        private HTMLElement root = new HTMLElement();
        public HTMLBuilder(string rootName)
        {
            this.rootName = rootName;
            root.Name = rootName;
        }
        public void AddChild(string childName, string childText)
        {
            var e = new HTMLElement(childName, childText);
            root.Elements.Add(e);
        }
        public HTMLBuilder AddChildFluent(string childName, string childText)
        {
            var e = new HTMLElement(childName, childText);
            root.Elements.Add(e);
            return this;
        }

        public override string ToString()
        {
            return root.ToString();
        }

        public void Clear()
        {
            root = new HTMLElement { Name = rootName };
        }

    }
}
