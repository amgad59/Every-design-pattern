/*
 *  Abstract Factory pattern 2
 * 
 * 
using Factory_Pattern.Abstract_Factory_Pattern_2;
using Factory_Pattern.Abstract_Factory_Pattern_2.Interfaces;

AbstractFactory roundedFactory = FactoryBuilder.getFactory("Rounded");

Shape roundedshape = roundedFactory.GetShape("Square");
roundedshape.draw();

AbstractFactory normalFactory = FactoryBuilder.getFactory("Normal");

Shape shape = normalFactory.GetShape("Square");
shape.draw();

*/
/*
 * 
 * Abstract Factory pattern 1
using Factory_Pattern.Abstract_Factory_Pattern;
using Factory_Pattern.Abstract_Factory_Pattern.Interfaces;

HotDrinksMachine machine = new HotDrinksMachine();
var Coffefactory = machine.namedFactories.Where(u=>u.Item1 == "Coffee");
IHotDrink HotCoffee = Coffefactory.FirstOrDefault().Item2.Prepare(300);
HotCoffee.Consume();
var Teafactory = machine.namedFactories.Where(u=>u.Item1 == "Tea");
IHotDrink HotTea = Teafactory.FirstOrDefault().Item2.Prepare(300);
HotTea.Consume();

*/

/*
 * Factory Pattern another method
 * 
using Factory_Pattern.Factory_Pattern_2;
using Factory_Pattern.Factory_Pattern_2.Interfaces;

ShapeFactory shapeFactory = new ShapeFactory();
Shape shape = shapeFactory.GetShape("Square");
Shape shape1 = shapeFactory.GetShape("Rectangle");
Shape shape2 = shapeFactory.GetShape("Circle");
shape.draw();
shape1.draw();
shape2.draw();

*/
/*
 * 
 * Factory Pattern

using Factory_Pattern;
using static Factory_Pattern.Point;

Point p = Factory.getPolarPoint(3, 4);
Console.WriteLine(p);

*/