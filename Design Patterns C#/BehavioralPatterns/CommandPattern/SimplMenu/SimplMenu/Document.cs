using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplMenu
{
    class Document
    {
        public static string clipboard;

        string name;

        string oldpage;

        string page;

        public Document(string name)
        {
            this.name = name;
        }

        public void Paste()
        {
            oldpage = page;
            page += clipboard + "\n";
        }

        public void Restore()
        {
            page = oldpage;
        }

        public void Print()
        {
            Console.WriteLine("File " + name + " at " + DateTime.Now + "\n" + page);
        }
    }
}
