using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight_Pattern.FlyWeightPattern_2
{
    public class OptimizedFormattedText
    {
        public class TextRange
        {
            public int start, end;
            public bool Capitalize,Bold,Italic;
            public bool Covers(int idx)
            {
                return idx >= start && idx <= end;
            }
        }
        private string plainText;
        private List<TextRange> formatting = new List<TextRange>();
        public OptimizedFormattedText(string plainText)
        {
            this.plainText = plainText;
        }
        public TextRange addFormatting(int start,int end)
        {
            var range = new TextRange { start = start, end = end };
            formatting.Add(range);
            return range;
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            for(int i = 0; i < plainText.Length; i++)
            {
                var c = plainText[i];
                foreach(TextRange range in formatting)
                {
                    if(range.Covers(i) && range.Capitalize)
                    {
                        c = char.ToUpperInvariant(c);
                    }
                    if(range.Covers(i) && range.Bold)
                    {
                        // Bold
                    }
                    if(range.Covers(i) && range.Italic)
                    {
                        // Italic
                    }
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }
    }
}
