using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandExtension
{
    class Command2
    {
        public static Invoker Execute, Redo, Undo;

        public static InvokerSet Set;

        public Command2(Receiver2 receiver)
        {
            Set = receiver.SetData;
            Execute = receiver.DoIt;
            Redo = receiver.DoIt;
            Undo = delegate
            {
                Console.WriteLine("Not Implemented");
            };
        }
    }
}
