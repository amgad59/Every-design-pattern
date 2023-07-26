using Command_Pattern.Command_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern.Command_Pattern
{
    public abstract class CompositeBankAccountCommand : List<BankAccountCommand>, ICommand
    {
        public virtual void Call()
        {
            ForEach(cmd=> cmd.Call());
        }


        public virtual void Undo()
        {
            foreach (var cmd in ((IEnumerable<BankAccountCommand>)this).Reverse()) 
            {
            cmd.Undo();
            }
        }
        public virtual bool Success
        {
            get { return this.All(cmd => cmd.Success); }
            set 
            { foreach(var cmd in this)
                    cmd.Success = value;
            }
        }
    }
}
