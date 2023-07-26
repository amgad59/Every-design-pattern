using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter_pattern.Interpreter_Pattern
{
    public class Integer : IElement
    {
        public Integer(int value)
        {
            Value = value;
        }
        public int Value { get; }
    }
}
