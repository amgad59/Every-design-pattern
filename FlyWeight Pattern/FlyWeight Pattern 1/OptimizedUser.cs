using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight_Pattern.FlyWeight_Pattern_1
{
    public class OptimizedUser
    {
        static List<string> users = new List<string>();
        private int[] names;
        public OptimizedUser(string fullName)
        {
            int getOrAdd(string s)
            {
                int idx = users.IndexOf(s);
                if (idx != -1)
                    return idx;
                else
                {
                    users.Add(s);
                    return users.Count - 1;
                }
            }
            names = fullName.Split(' ').Select(getOrAdd).ToArray();
        }
        public string fullName => string.Join(" ", names);
    }
}
