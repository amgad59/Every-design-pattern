using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern.Iterator_Pattern
{
    public class BinaryTree<T>
    {
        private Node<T> root;
        public BinaryTree(Node<T> root)
        {
            this.root = root;
        }
        public IEnumerable<Node<T>> NaturalInOrder
        {
            get
            {
                IEnumerable<Node<T>> traverseInOrder(Node<T> current)
                {
                    if(current.Left != null)
                    {
                        foreach(var left in traverseInOrder(current.Left))
                        {
                            yield return left;
                        }
                    }
                    yield return current;
                    if(current.Right != null)
                    {
                        foreach(var  right in traverseInOrder(current.Right))
                        { yield return right; }

                    }
                }
                foreach (var node in traverseInOrder(root))
                    yield return node;
            }
        }
        public InOrderIterator<T> GetEnumerator()
        {
            return new InOrderIterator<T>(root);
        }
    }
}
