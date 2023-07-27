using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Pattern.Mediator_Pattern_1_Chat_Room
{
    public class ChatRoom
    {
        private List<Person> Persons = new List<Person>();
        public void Join(Person p)
        {
            string JoinMessage = $"{p.Name} just joined";
            Broadcast("Room", JoinMessage);
            p.Room = this;
            Persons.Add(p);
        }
        public void Broadcast(string source, string message)
        {
            foreach (Person p in Persons)
            {
                if(p.Name != source)
                {
                    p.Receive(source, message);
                }
            }
        }
        public void Message(string source,string destination,string message)
        {
            Persons.FirstOrDefault(u=>u.Name == destination)?.Receive(source,message);
        }
    }
}
