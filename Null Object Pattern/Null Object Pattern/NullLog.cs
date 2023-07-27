using Null_Object_Pattern.Null_Object_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Null_Object_Pattern.Null_Object_Pattern
{
    public class NullLog : ILog
    {
        public void Log(string message)
        {
        }

        public void Warn(string message)
        {
        }
    }
}
