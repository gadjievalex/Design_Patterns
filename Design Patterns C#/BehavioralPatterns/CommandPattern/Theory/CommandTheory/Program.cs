using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandTheory
{
    class Program
    {
        static void Main(string[] args)
        {
            new Command(new Receiver());
            
            Command.Execute();
            Command.Redo();
            Command.Undo();
            Command.Execute();

            Console.ReadLine();
        }
    }
}
