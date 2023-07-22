using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.S_In_SOLID
{
    public class Journal
    {
        private List<string> entries = new List<string>();
        private static int count = 0;
        public void addEntry(string entry)
        {
            entries.Add($"{++count}: {entry}");
        }
        public void removeEntry(int Index)
        {
            entries.RemoveAt(Index);
        }
        public override string ToString()
        {
            return string.Join(Environment.NewLine, entries);
        }
    }
}
