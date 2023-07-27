using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Pattern.State_Pattern_2
{
    public class SD
    {
        public enum State
        {
            OffHook,
            Connecting,
            Connected,
            OnHold
        }
        public enum Trigger
        {
            CallDialed,
            HungUp,
            CallConnected,
            PlacedOnHold,
            TakenOffHold,
            LeftMessage
        }
    }
}
