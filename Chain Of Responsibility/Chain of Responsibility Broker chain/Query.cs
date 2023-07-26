using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_Of_Responsibility.Chain_of_Responsibility_Broker_chain
{
    public class Query
    {
        public string creatureName;
        public enum Argument
        {
            Attack,Defense
        }
        public Argument query;
        public int Value;
        public Query(string name,Argument argument,int value) {
            creatureName = name;
            query = argument;
            Value = value;
        }
    }
}
