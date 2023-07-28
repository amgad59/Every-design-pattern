using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor_Pattern.Visitor_Pattern_2_Acyclic_implementation.Interfaces;

namespace Visitor_Pattern.Visitor_Pattern_2_Acyclic_implementation
{
    public abstract class Expression
    {
        public virtual void Accept(IVisitor visitor)
        {
            if (visitor is IVisitor<Expression> typed)
                typed.Visit(this);
        }
    }
}
