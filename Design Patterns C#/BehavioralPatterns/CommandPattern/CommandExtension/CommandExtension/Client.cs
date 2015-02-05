using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandExtension
{
    class Client
    {
        public void ClientMain()
        {
            new Command(new Receiver());
            Command.Execute();
            Command.Redo();
            Command.Undo();
            Command.Set("III");
            Command.Execute();

            Console.WriteLine();

            new Command2(new Receiver2());

            Command2.Set("houses");
            Command2.Execute();
            Command2.Set("casting");
            Command2.Undo();
            Command2.Execute();
            Command2.Redo();
        }
    }
}
