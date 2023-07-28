using Strategy_Pattern.Strategy_Pattern_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Strategy_Pattern.Strategy_Pattern_1.SD;

namespace Strategy_Pattern.Strategy_Pattern_1
{
    public class TextProcessor<LS> where LS : IListStrategy,new() // static setting of the output format
    {
        private IListStrategy listStrategy = new LS();
        private StringBuilder sb = new StringBuilder();

        //dynamically setting the output format
        public void SetOutputFormat(OutputFormat outputFormat)
        {
            switch(outputFormat)
            {
                case OutputFormat.Markdown: 
                    listStrategy = new MarkdownListStrategy();
                    break;
                case OutputFormat.Html: 
                    listStrategy = new HtmlListStrategy();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        public void AppendList(IEnumerable<string> list)
        {
            listStrategy.Start(sb);
            foreach (string s in list)
            listStrategy.AddListItem(sb, s);
            listStrategy.End(sb);
        }

        public void clear()
        {
            sb.Clear();
        }
        public override string ToString()
        {
            return sb.ToString();
        }
    }
}
