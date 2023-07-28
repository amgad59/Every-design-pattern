

/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor_Pattern.Visitor_pattern_1.Interfaces;

namespace Visitor_Pattern.Visitor_pattern_1
{
    internal class ExpressionPrinter : IExpressionVisitor
    {
        StringBuilder sb = new StringBuilder();
        public void Visit(DoubleExpression expression)
        {
            sb.Append(expression.value);
        }

        public void Visit(AdditionExpression expression)
        {
            sb.Append('(');
            expression.Left.Accept(this);
            sb.Append('+');
            expression.Right.Accept(this);
            sb.Append(')');
        }
        public override string ToString()
        {
            return sb.ToString();
        }
    }
}
*/