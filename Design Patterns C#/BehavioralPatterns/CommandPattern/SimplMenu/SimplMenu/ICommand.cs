using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplMenu
{
    public abstract class ICommand
    {
        public Invoker Execute;
        public Invoker Redo;
        public Invoker Undo;
    }
}
