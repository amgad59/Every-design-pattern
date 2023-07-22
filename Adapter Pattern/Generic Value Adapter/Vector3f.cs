using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Adapter_Pattern.Generic_Value_Adapter
{
    public class Vector3f : VectorOfFloat<Vector3f,Dimensions.Three>
    {
        public override string ToString()
        {
            return $"{string.Join(",", Data)}";
        }
    }
}
