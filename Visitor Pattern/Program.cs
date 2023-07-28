

using Visitor_Pattern.Visitor_Pattern_2_Acyclic_implementation;

var e = new AdditionExpression(
  Left: new DoubleExpression(1),
  Right: new AdditionExpression(
    Left: new DoubleExpression(2),
    Right: new DoubleExpression(3)));
var ep = new ExpressionPrinter();
ep.Visit(e);
Console.WriteLine(ep.ToString());