using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter_pattern.Interpreter_Pattern
{
    public class BinaryOperation : IElement
    {
        public Type MyType;
        public IElement Left, Right;
        public enum Type
        {
            Addition,Subtraction
        }
        public int Value
        {
            get
            {
                switch (MyType)
                {
                    case Type.Addition:
                        return Left.Value + Right.Value;
                    case Type.Subtraction:
                        return Left.Value - Right.Value;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }
    }
}
