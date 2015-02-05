using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandTheory
{
    delegate void Invoker();

    class Command
    {
        public static Invoker Execute, Undo, Redo;

        public Command(Receiver receiver)
        {
            Execute = receiver.Action;
            Redo = receiver.Action;
            Undo = receiver.Reverce;
        }
    }
}
