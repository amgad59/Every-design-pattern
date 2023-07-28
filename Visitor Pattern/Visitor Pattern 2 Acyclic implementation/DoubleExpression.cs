using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor_Pattern.Visitor_Pattern_2_Acyclic_implementation.Interfaces;

namespace Visitor_Pattern.Visitor_Pattern_2_Acyclic_implementation
{
    public class DoubleExpression : Expression
    {
        public double Value;
        public DoubleExpression(double Value)
        {
            this.Value = Value;
        }
        public override void Accept(IVisitor visitor)
        {
            if (visitor is IVisitor<DoubleExpression> typed)
                typed.Visit(this);
        }
    }
}
