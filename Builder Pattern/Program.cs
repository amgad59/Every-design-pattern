

using Builder_Pattern.Faceted_Builder;

PersonBuilder pb = new PersonBuilder();
Person p = pb.Works
    .At("Google")
    .AsA("Developer")
    .Earning(25000)
  .Lives
    .At("New Cairo")
    .City("Cairo");
Console.WriteLine(p.ToString());
/*
 * Functional Builder
 * 
using Builder_Pattern.Functional_Builder;

var pb = new PersonBuilder();
var person = pb.Called("Amgad").WorksAsA(".Net Dev").build();
Console.WriteLine(person.name);
Console.WriteLine(person.position);


*/
/*
using Builder_Pattern.Fluent_Builder_with_Recursive_Generics;

var me = Person.New
  .Called("Amgad")
  .WorkAs(".Net Dev")
  .build();
Console.WriteLine(me);
*/
/*
 * Builder Design Pattern
 * 
using Builder_Pattern.Builder;

var builder = new HTMLBuilder("ul");
builder.AddChild("li", "hello");
builder.AddChild("li", "world");
Console.WriteLine(builder.ToString());

var builder1 = new HTMLBuilder("ul");
builder1.AddChildFluent("li", "hello").AddChildFluent("li", "hello");
Console.WriteLine(builder1.ToString());
*/