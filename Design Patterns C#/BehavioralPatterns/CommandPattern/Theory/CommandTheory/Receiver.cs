using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandTheory
{
    class Receiver
    {
        string build;
        string oldbuild;
        string s = "some string";

        public void Action()
        {
            oldbuild = build;
            build += s;
            Console.WriteLine("Receiver is adding " + build);
        }

        public void Reverce()
        {
            build = oldbuild;
            Console.WriteLine("Receiver is reverting to " + build);
        }
    }
}
