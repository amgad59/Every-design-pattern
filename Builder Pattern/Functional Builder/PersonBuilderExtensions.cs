using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern.Functional_Builder
{

    public static class PersonBuilderExtensions
    {
        public static PersonBuilder WorksAsA
          (this PersonBuilder builder, string position)
        {
            builder.actions.Add(p =>
            {
                p.position = position;
            });
            return builder;
        }
    }
}
