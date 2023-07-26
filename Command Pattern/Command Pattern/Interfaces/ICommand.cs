using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern.Command_Pattern.Interfaces
{
    public interface ICommand
    {
        void Call();
        void Undo();
        bool Success { get; set; }
    }
}
