using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Pattern.Neural_Network_using_Composite_pattern
{
    public static class ExtensionMethods
    {
        public static void ConnectTo(this IEnumerable<Neuron> self, IEnumerable<Neuron> other)
        {
            if(ReferenceEquals(self, other)) return;
            foreach(var neuron in self)
            {
                foreach(var otherNeuron in other)
                {
                    neuron.Out.Add(otherNeuron);
                    otherNeuron.In.Add(neuron);
                }
            }
        }
    }
}
