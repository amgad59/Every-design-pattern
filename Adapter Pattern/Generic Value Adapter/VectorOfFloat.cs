using Adapter_Pattern.Generic_Value_Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern.Generic_Value_Adapter
{
    public class VectorOfFloat<TSelf,D> : Vector<TSelf,float,D>
        where TSelf : VectorOfFloat<TSelf,D> ,new()
        where D : IInteger ,new()
    {
        public static VectorOfFloat<TSelf,D> operator +
            (VectorOfFloat<TSelf,D> rhs,VectorOfFloat<TSelf, D> lhs)
        {
            var result = new VectorOfFloat<TSelf, D>();
            var dim = new D().Value;
            for(int i = 0; i < dim; i++)
            {
                result[i] = lhs[i] + rhs[i];
            }
            return result;
        }
        public override string ToString()
        {
            return $"{string.Join(",", Data)}";
        }
    }
}
