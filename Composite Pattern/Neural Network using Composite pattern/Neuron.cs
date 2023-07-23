using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Pattern.Neural_Network_using_Composite_pattern
{
    public class Neuron : IEnumerable<Neuron>
    {
        public float Value; 
        public List<Neuron> In = new List<Neuron>(), Out = new List<Neuron>();

        public IEnumerator<Neuron> GetEnumerator()
        {
            yield return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            yield return this;
        }
    }
}
