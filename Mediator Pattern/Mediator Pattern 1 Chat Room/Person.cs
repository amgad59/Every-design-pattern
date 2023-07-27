using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Pattern.Mediator_Pattern_1_Chat_Room
{
    public class Person
    {
        public string Name;
        public ChatRoom Room;
        public List<string> chatLogs = new List<string>();
        public Person(string Name)
        {
            this.Name = Name;
        }
        public void Receive(string sender, string message)
        {
            string s = $"{sender}: '{message}'";
            Console.WriteLine($"[{Name}'s chat session] {s}");
            chatLogs.Add(s);
        }
        public void BroadCast(string message)
        {
            Room.Broadcast(Name, message);
        }
        public void Send(string receiver, string message)
        {
            Room.Message(Name, receiver, message);
        }
    }
}
