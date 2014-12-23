using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealProxyExample
{
    class SpaceBook
    {
        static SortedList<string, SpaceBook> comunity = new SortedList<string, SpaceBook>(100);

        string pages;

        string name;

        string gap = "\n\t\t\t\t";

        static public bool IsUnique(string name)
        {
            return comunity.ContainsKey(name);
        }
        
        internal SpaceBook(string n)
        {
            name = n;

            comunity[n] = this;
        }

        internal void Add(string s)
        {
            pages += gap + s;

            Console.WriteLine(gap + "===" + name + "===" + "Space book");
            Console.WriteLine(pages);
            Console.WriteLine(gap + "=================================");
        }

        internal void Add(string friend, string mesage)
        {
            comunity[friend].Add(mesage);
        }

        internal void Poke(string who, string friend)
        {
            comunity[who].pages += gap + friend + " pocked you ";
        }
    }
}
