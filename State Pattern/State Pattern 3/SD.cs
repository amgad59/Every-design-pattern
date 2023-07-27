using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Pattern.State_Pattern_3
{
    public class SD
    {
        public enum Chest
        {
            Open,
            Closed,
            Locked
        }
        public enum Action
        {
            Open,
            Close
        }
    }
}
