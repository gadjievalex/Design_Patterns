using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandExtension
{
    class Receiver2
    {
        string build;
        string oldbuild;
        string s = "some string";

        public void SetData(string s)
        {
            this.s = s;
        }

        public void DoIt()
        {
            oldbuild = build;
            build += s;
            Console.WriteLine("Receiver is build" + build);
        }
    }
}
