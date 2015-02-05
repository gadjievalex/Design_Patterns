using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplMenu
{
    class CommandPaste:ICommand
    {
        public CommandPaste(Document document)
        {
            Execute=delegate
            {
                Execute.Log();
                document.Paste();
            };
            Redo=delegate
            {
                Redo.Log();
                document.Paste();
            };
            Undo=delegate
            {
                Undo.Log();
                document.Restore();
            };
        }
    }
}
