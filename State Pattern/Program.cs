/*
 * State Pattern example 3
 * 
using State_Pattern.State_Pattern_3;
using static State_Pattern.State_Pattern_3.SD;

Chest chest = Chest.Locked;
Console.WriteLine($"Chest is {chest}");

chest = SwitchExpressions.Manipulate(chest, SD.Action.Open, true);
Console.WriteLine($"Chest is now {chest}");

chest = SwitchExpressions.Manipulate(chest, SD.Action.Close, false);
Console.WriteLine($"Chest is now {chest}");

chest = SwitchExpressions.Manipulate(chest, SD.Action.Close, false);
Console.WriteLine($"Chest is now {chest}");
*/
/*
 *Phone example example
 *
using State_Pattern.State_Pattern_2;
using static State_Pattern.State_Pattern_2.SD;
Dictionary<State, List<(Trigger, State)>> rules
    = new Dictionary<State, List<(Trigger, State)>>
    {
        [State.OffHook] = new List<(Trigger, State)>
            {
                      (Trigger.CallDialed, State.Connecting)
            },
        [State.Connecting] = new List<(Trigger, State)>
            {
                      (Trigger.HungUp, State.OffHook),
                      (Trigger.CallConnected, State.Connected)
            },
        [State.Connected] = new List<(Trigger, State)>
            {
                      (Trigger.LeftMessage, State.OffHook),
                      (Trigger.HungUp, State.OffHook),
                      (Trigger.PlacedOnHold, State.OnHold)
            },
        [State.OnHold] = new List<(Trigger, State)>
            {
                      (Trigger.TakenOffHold, State.Connected),
                      (Trigger.HungUp, State.OffHook)
            }
    };
var state = State.OffHook;
while (true)
{
    Console.WriteLine($"the phone is currently {state}");
    Console.WriteLine($"Select a trigger \n");
    for( int i = 0; i < rules[state].Count; i++)
    {
        var d = rules[state][i];
        Console.WriteLine($"{i}. {d.Item1}");
    }
    int Input = int.Parse(Console.ReadLine());
    var (_, s) = rules[state][Input];
    state = s;
}
*/
/*
 * 
 * 
using State_Pattern.State_Pattern_1_Classic_Implementation;

Switch sw = new Switch();
sw.On();
sw.Off();
sw.On();
sw.On();
*/