using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor_Pattern.Visitor_Pattern_2_Acyclic_implementation.Interfaces;

namespace Visitor_Pattern.Visitor_Pattern_2_Acyclic_implementation
{
    public class ExpressionPrinter : IVisitor
        , IVisitor<Expression>
        , IVisitor<DoubleExpression>
        , IVisitor<AdditionExpression>
    {
        StringBuilder sb = new StringBuilder();
        public void Visit(AdditionExpression obj)
        {
            sb.Append('(');
            obj.Right.Accept(this);
            sb.Append('+');
            obj.Left.Accept(this);
            sb.Append(')');
        }

        public void Visit(DoubleExpression obj)
        {
            sb.Append(obj.Value);
        }

        public void Visit(Expression obj)
        {

        }
        public override string ToString()
        {
            return sb.ToString();
        }
    }
}
