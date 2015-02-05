using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandExtension
{
    class Receiver
    {
        string build;
        string oldbuild;
        string s = "some string";

        public string S
        {
            get
            {
                return s;
            }
            set
            {
                s = value;
            }
        }

        public void Action()
        {
            oldbuild = build;
            build += s;
            Console.WriteLine("Receiver is adding " + build);
        }

        public void Reverce()
        {
            build = oldbuild;
            Console.WriteLine(" reeciver is reverting " + build);
        }
    }
}
