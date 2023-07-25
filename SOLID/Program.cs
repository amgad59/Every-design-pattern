
Console.WriteLine("Test");

/*
 * high level modules shouldn't depend on low level modules; use abstractions
 * 
 * 
using SOLID.D_in_SOLID;

var parent = new Person { Name = "John" };
var child1 = new Person { Name = "Chris" };
var child2 = new Person { Name = "Matt" };

// low-level module
var relationships = new RelationShips();
relationships.AddParentAndChild(parent, child1);
relationships.AddParentAndChild(parent, child2);

var r = new Research(relationships);

*/
/*
 * Interface Segregation:-
 * states that a class doesn't have to implement unnecessary methods 
 * 
 */


/*
 * Liskov Substitution principle:-
 * states that the program should be made so that you can substitute an object 
 * by a sub-object without breaking the program 
 * 
 * 
using SOLID.L_in_SOLID;

static int Area(Rectangle r) => r.width * r.height;

Rectangle r = new Rectangle(3,4);
Rectangle r1 = new Square();
r1.width = 5;
r1.height = 6;
Console.WriteLine(Area(r));
Console.WriteLine(Area(r1));

*/


/*
 * The Open for extension closed for modification Principle  
 * this principle states that any class can be extended and generalized for any other classes to come like in the
 * repository pattern
 * 
 * 
using SOLID.O_in_SOLID;
using SOLID.O_in_SOLID.Repository;
using static SOLID.O_in_SOLID.SD;

var apple = new Product("Apple", Color.Green, Size.Small);
var tree = new Product("Tree", Color.Green, Size.Large);
var house = new Product("House", Color.Blue, Size.Large);

Product[] products = { apple, tree, house };



var bf = new FilterProduct();
Console.WriteLine("Green products (new):");
foreach (var p in bf.Filter(products, new ColorSpecification(Color.Green)))
    Console.WriteLine($" - {p.Name} is green");

foreach (var p in bf.Filter(products, new SizeSpecification(Size.Large)))
    Console.WriteLine($" - {p.Name} is Large");

foreach (var p in bf.Filter(products, new AndSpecification<Product>(new ColorSpecification(Color.Green),new SizeSpecification(Size.Large))))
    Console.WriteLine($" - {p.Name} is Large and green");

*/




/*
 * Single Responsibility Principle 
 * The Journal class isn't responsible for saving and loading the data but only for the adding 
 * and removing the entries
 * So we create a new class for saving and loading the data
 * 


using SOLID.S_In_SOLID;

Journal j =  new Journal();
j.addEntry("Hello World");
j.addEntry("Second Journal Entry");
Console.WriteLine(j.ToString());

var p = new Persistence();

p.SaveToFile(j,@"F:\Career\journal.txt");*/