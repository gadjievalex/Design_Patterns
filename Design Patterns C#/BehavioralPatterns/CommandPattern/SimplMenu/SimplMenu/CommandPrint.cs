using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplMenu
{
    class CommandPrint:ICommand
    {
        public CommandPrint(Document document)
        {
            Execute = delegate
            {
                Redo.Log();
                document.Print();
            };
            Redo = delegate
            {
                Redo.Log();
                document.Print();
            };
            Undo = delegate
            {
                Redo.Log();
                Console.WriteLine("Cannnot undo a print");
            };
        }
    }
}
