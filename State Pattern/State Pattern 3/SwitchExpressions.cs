using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static State_Pattern.State_Pattern_3.SD;

namespace State_Pattern.State_Pattern_3
{
    public class SwitchExpressions
    {
        public static Chest Manipulate(Chest chest,
            SD.Action action, bool HaveKey) =>
            (chest, action, HaveKey) switch
            {
                (Chest.Closed, SD.Action.Open, _) => Chest.Open,
                (Chest.Locked, SD.Action.Open, true) => Chest.Open,
                (Chest.Open, SD.Action.Close, true) => Chest.Locked,
                (Chest.Open, SD.Action.Close, false) => Chest.Closed,
                _ => chest
            };
    }
}
