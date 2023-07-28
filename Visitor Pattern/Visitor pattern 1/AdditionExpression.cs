﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor_Pattern.Visitor_pattern_1.Interfaces;

namespace Visitor_Pattern.Visitor_pattern_1
{
    public class AdditionExpression : Expression
    {
        public Expression Left, Right;
        public AdditionExpression(Expression Left, Expression Right)
        {
            this.Left = Left;
            this.Right = Right;
        }
        public override void Accept(IExpressionVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
