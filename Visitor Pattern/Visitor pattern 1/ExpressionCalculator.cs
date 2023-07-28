using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor_Pattern.Visitor_pattern_1.Interfaces;

namespace Visitor_Pattern.Visitor_pattern_1
{
    public class ExpressionCalculator : IExpressionVisitor
    {
        public double result;

        public void Visit(DoubleExpression expression)
        {
            result = expression.value;
        }

        public void Visit(AdditionExpression expression)
        {
            expression.Left.Accept(this);
            var a = result;
            expression.Right.Accept(this);
            var b = result;
            result = a + b;
        }
    }
}
