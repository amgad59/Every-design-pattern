
/*
 * Memory Efficient example
 * 
using Proxy_Pattern.Proxy_Pattern_2;

var creatures = new Creature[100];
for(int i =0;i<creatures.Length;i++)
{
    creatures[i] = new Creature();
    creatures[i].X++; // Not memory Efficient
}
var creatures2 = new Creatures(100);
foreach (var creature in creatures2)
{
    creature.x++; // memory Efficient
}
*/
/*
 * 
 * Perctange Pattern
 * 
using Proxy_Pattern.Proxy_Pattern_1_Percantage;

Console.WriteLine(10f * 5.Percent());
Console.WriteLine(2.Percent() + 3.Percent());
*/
/*
 * 
 * Protection Proxy
 * 
using Proxy_Pattern.Protection_Pattern;

ICar CarProxy = new CarProxy(new Driver(11));

CarProxy.Drive();*/