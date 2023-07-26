/*
 * 
 * 
using Chain_Of_Responsibility.Chain_of_Responsibility_Broker_chain;

var game = new Game();
var goblin = new Creature(game, "Goblin", 5, 5);
Console.WriteLine(goblin);
using (new DoubleAttackModifier(game, goblin))
{
    Console.WriteLine(goblin);
    using (new IncreaseDefenseModifier(game, goblin))
    {
        Console.WriteLine(goblin);
    }
}
Console.WriteLine(goblin);
*/
/*
 * Method Chain 
 * 
using Chain_Of_Responsibility.Chain_of_Responsibility_Method_chain;

var goblin = new Creature("Goblin", 2, 2);
Console.WriteLine(goblin);

var root = new CreatureModifier(goblin);

root.Add(new NoBonusesModifier(goblin));

Console.WriteLine("Let's double goblin's attack...");
root.Add(new DoubleAttackModifier(goblin));

Console.WriteLine("Let's increase goblin's defense");
root.Add(new IncreaseDefenseModifier(goblin));

// eventually...
root.Handle();
Console.WriteLine(goblin);

 
 */