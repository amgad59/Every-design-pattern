using Strategy_Pattern.Strategy_Pattern_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.Strategy_Pattern_1
{
    public class HtmlListStrategy : IListStrategy
    {
        public void AddListItem(StringBuilder sb, string item)
        {
            sb.AppendLine($"    <li>{item}</li>");
        }

        public void End(StringBuilder sb)
        {
            sb.AppendLine($"</ul>");
        }

        public void Start(StringBuilder sb)
        {
            sb.AppendLine($"<ul>");
        }
    }
}
