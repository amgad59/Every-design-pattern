
using Prototype_Pattern;
using Prototype_Pattern.Prototype_Pattern;

Person p = new Person(new[] {"Amgad","Aly"},new Address { houseNumber=300,streetAddress = "12 g Street"} );


Person p1 = p.DeepCopy();
p1.names[0] = "Ahmad";
Console.WriteLine(p.ToString());
Console.WriteLine( p1.ToString() );