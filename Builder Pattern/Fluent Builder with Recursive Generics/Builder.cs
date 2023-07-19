using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern.Fluent_Builder_with_Recursive_Generics
{
    public class Builder : PersonJobBuilder<Builder>
    {
    }
}
