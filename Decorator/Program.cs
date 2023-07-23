using Decorator_Pattern.Decorator_Pattern;

Circle circle = new Circle(3.0f);
Console.WriteLine(circle.AsString());
ColoredShape coloredShape = new ColoredShape(circle, "Green");
Console.WriteLine(coloredShape.AsString());
TransparentShape transparentShape = new TransparentShape(coloredShape, 0.4f);
Console.WriteLine(transparentShape.AsString());