using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealBridgeRealisation
{
    class SpaceBook
    {
        static SortedList<string, SpaceBook> comunity = new SortedList<string, SpaceBook>(100);

        string pages = string.Empty;

        string name;

        string gap = "\n\t\t\t\t";

        static public bool IsUnique(string name)
        {
            return comunity.ContainsKey(name);
        }

        public SpaceBook(string n)
        {
            name = n;

            comunity[n] = this;
        }
        public  void Add(string s)
        {
            pages += gap + s;

            Console.WriteLine(gap + "===" + name + "=== SpaceBook ");
            Console.WriteLine(pages);
            Console.WriteLine(gap + "=============================");
        }
        public void Add(string friend, string message)
        {
            comunity[friend].Add(message);
        }
        public void Poke(string who, string friend)
        {
            comunity[who].pages += gap + friend + "pocked you";
        }
    }
}
