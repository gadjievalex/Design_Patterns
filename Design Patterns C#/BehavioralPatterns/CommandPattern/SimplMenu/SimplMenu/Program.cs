using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Document document = new Document("Greetings");
            CommandPaste paste = new CommandPaste(document);
            CommandPrint print = new CommandPrint(document);

            Document.clipboard = "external string";
            paste.Execute();
            print.Execute();
            paste.Undo();

            Document.clipboard = "france language string";
            paste.Execute();
            Document.clipboard = "deutche language string";
            paste.Redo();
            print.Execute();
            print.Undo();

            Console.WriteLine("Logged " + paste.Execute.Count() + " commands ");
            Console.ReadKey();
        }
    }
}
