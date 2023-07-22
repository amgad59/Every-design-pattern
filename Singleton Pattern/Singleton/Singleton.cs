using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Pattern.Singleton
{
    public class Singleton
    {
        public static string capitals;
        private static Lazy<Singleton> instance = new Lazy<Singleton>(() => {
            return new Singleton();
            });
        private Singleton()
        {
            capitals = File.ReadAllText("capitals.txt");
        }
        public static string values = instance.Value.ToString();
    }
}
