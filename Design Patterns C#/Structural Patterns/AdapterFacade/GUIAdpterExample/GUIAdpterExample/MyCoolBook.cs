using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GUIAdpterExample
{
    class MyCoolBook:MyOpenBook
    {
        static SortedList<string, MyCoolBook> community = new SortedList<string, MyCoolBook>(100);

        Interact visuals;

        public MyCoolBook(string name):base(name)
        {
            new Thread
           (delegate()
                    {
                        visuals = new Interact("CoolBook bets");
                    }
            );
        }
    }
}
