using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Null_Object_Pattern.Null_Object_Pattern.Interfaces
{
    public interface ILog
    {
        void Log(string message);
        void Warn(string message);
    }
}
