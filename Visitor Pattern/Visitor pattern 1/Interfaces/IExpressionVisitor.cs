using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_Pattern.Visitor_pattern_1.Interfaces
{
    public interface IExpressionVisitor
    {
        void Visit(DoubleExpression expression);
        void Visit(AdditionExpression expression);
    }
}
