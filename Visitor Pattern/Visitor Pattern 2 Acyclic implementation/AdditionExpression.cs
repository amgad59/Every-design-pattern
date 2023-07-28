using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor_Pattern.Visitor_Pattern_2_Acyclic_implementation.Interfaces;

namespace Visitor_Pattern.Visitor_Pattern_2_Acyclic_implementation
{
    public class AdditionExpression : Expression
    {
        public Expression Left, Right;
        public AdditionExpression(Expression Left, Expression Right)
        {
            this.Left = Left;
            this.Right = Right;
        }
        public override void Accept(IVisitor visitor)
        {
            if (visitor is IVisitor<AdditionExpression> typed)
                typed.Visit(this);
        }
    }
}
