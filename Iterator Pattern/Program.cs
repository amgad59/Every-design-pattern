/*
 * Iterator Pattern
 * 
using Iterator_Pattern.Iterator_Pattern;
using Iterator_Pattern;

var root = new Node<int>(1,
  new Node<int>(2), new Node<int>(3));

var it = new InOrderIterator<int>(root);

while (it.MoveNext())
{
    Console.Write(it.Current.Value);
    Console.Write(',');
}
Console.WriteLine();

var tree = new BinaryTree<int>(root);

Console.WriteLine(string.Join(",", tree.NaturalInOrder.Select(x => x.Value)));

// duck typing
foreach (var node in tree)
    Console.WriteLine(node.Value);
*/