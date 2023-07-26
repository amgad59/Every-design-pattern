using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern
{
    public class Node<T>
    {
        public T Value;
        public Node<T> Parent;
        public Node<T> Left, Right;

        public Node(T Value)
        {
            this.Value = Value;
        }
        public Node(T Value,Node<T> Left,Node<T> Right)
        {
            this.Value = Value;
            this.Left = Left;
            this.Right = Right;
            Left.Parent = Right.Parent = this;
        }
    }
}
