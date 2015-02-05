using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandExtension
{
    delegate void Invoker();

    delegate void InvokerSet(string s);

    class Command
    {
        public static Invoker Execute, Redo, Undo;

        public static InvokerSet Set;

        public Command(Receiver receiver)
        {
            Set = delegate
            {
                Console.WriteLine("Not Implemented - default of XXX used");
                receiver.S = "XXX";
            };
            Execute = receiver.Action;
            Redo = receiver.Action;
            Undo = receiver.Reverce;
        }
    }
}
