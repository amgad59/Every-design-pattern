using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter_pattern.Interpreter_Pattern
{
    public static class HelperMethods
    {
        public static List<Token> Lex(string Input)
        {
            var result = new List<Token>();
            for(int i =0;i< Input.Length; i++)
            {
                switch(Input[i])
                {
                    case '+':
                        result.Add(new Token(Token.Type.Plus, "+"));
                        break;
                    case '-':
                        result.Add(new Token(Token.Type.Minus, "-"));
                        break;
                    case '(':
                        result.Add(new Token(Token.Type.Lparen, "("));
                        break;
                    case ')':
                        result.Add(new Token(Token.Type.Rparen, ")"));
                        break;
                    default:
                        var sb = new StringBuilder(Input[i].ToString());
                        for(int j = i+1;j< Input.Length; j++)
                        {
                            if (char.IsDigit(Input[j]))
                            {
                                sb.Append(Input[j]);
                                i++;
                            }
                            else
                            {
                                result.Add(new Token(Token.Type.Integer, sb.ToString()));
                                break;
                            }
                        }
                        break;
                }
            }
            return result;
        }
        public static IElement Parse(IReadOnlyList<Token> tokens)
        {
            var result = new BinaryOperation();
            bool haveLHS = false;
            for(int i =0;i< tokens.Count; i++)
            {
                var token = tokens[i];
                switch (token.myType)
                {
                    case Token.Type.Integer:
                        var integer = new Integer(int.Parse(token.Text));
                        if (!haveLHS)
                        {
                            result.Left = integer;
                            haveLHS = true;
                        }
                        else
                        {
                            result.Right = integer;
                        }
                        break;
                    case Token.Type.Minus:
                        result.MyType = BinaryOperation.Type.Subtraction;
                        break;
                    case Token.Type.Plus:
                        result.MyType = BinaryOperation.Type.Addition;
                        break;
                    case Token.Type.Lparen:
                        int j = i;
                        for (; j < tokens.Count; j++)
                        {
                            if (tokens[j].myType == Token.Type.Rparen)
                            {
                                break;
                            }
                        }
                        var subExpression = tokens.Skip(i + 1).Take(j - i - 1).ToList();
                        var element = Parse(subExpression); 
                        if (!haveLHS)
                        {
                            result.Left = element;
                            haveLHS = true;
                        }
                        else result.Right = element;
                        i = j; // advance
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
            return result;
        }
    }
}
