using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Pattern.Mediator_Pattern_2.PlayerEvents
{
    internal class PlayerSentOffEvent : PlayerEvent
    {
        public string Reason { get; set; }
    }
}
