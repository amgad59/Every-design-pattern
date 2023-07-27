/*
 * Football Game example
 * 
using Autofac;
using Mediator_Pattern.Mediator_Pattern_2;
using Mediator_Pattern.Mediator_Pattern_2.Characters;

var cb = new ContainerBuilder();
cb.RegisterType<EventBroker>().SingleInstance();
cb.RegisterType<Referee>();
cb.RegisterType<Coach>();
cb.Register((c, p) => new Player(c.Resolve<EventBroker>(),p.Named<string>("name")));

using (var c = cb.Build())
{
    var referee = c.Resolve<Referee>();
    var coach = c.Resolve<Coach>();
    var player1 = c.Resolve<Player>(new NamedParameter("name", "John"));
    var player2 = c.Resolve<Player>(new NamedParameter("name", "Chris"));
    player1.Score();
    player1.Score();
    player1.Score(); 
    player1.AssaultReferee();
}*/
/*
 * Chat room example
 * 
using Mediator_Pattern.Mediator_Pattern_1_Chat_Room;

var room = new ChatRoom();

var john = new Person("John");
var jane = new Person("Jane");

room.Join(john);
room.Join(jane);

john.BroadCast("hi room");
jane.BroadCast("oh, hey john");

var simon = new Person("Simon");
room.Join(simon);
simon.BroadCast("hi everyone!");

jane.Send("Simon", "glad you could join us!");*/