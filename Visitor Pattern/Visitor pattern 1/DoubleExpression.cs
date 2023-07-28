using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor_Pattern.Visitor_pattern_1.Interfaces;

namespace Visitor_Pattern.Visitor_pattern_1
{
    public class DoubleExpression : Expression
    {
        public double value;
        public DoubleExpression(double value)
        {
            this.value = value;
        }
        public override void Accept(IExpressionVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
