using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter_pattern.Interpreter_Pattern
{
    public class Token
    {
        public enum Type
        {
            Integer,Plus,Minus,Lparen,Rparen
        }
        public Type myType;
        public string Text;
        public Token(Type type, string text)
        {
            myType = type;
            Text = text;
        }
        public override string ToString()
        {
            return $"`{Text}`";
        }
    }
}
