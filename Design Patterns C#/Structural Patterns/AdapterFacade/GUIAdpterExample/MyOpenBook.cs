using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealBridgeRealisation
{
    class MyOpenBook:Bridge
    {
        SpaceBook myOpenBook;

        string name;

        static int users;

        public MyOpenBook(string n)
        {
            name = n;
            users++;
            myOpenBook = new SpaceBook(name + " - " + users);
        }

        public void Add(string message)
        {
            myOpenBook.Add(message);
        }

        public void Add(string friend, string message)
        {
            myOpenBook.Add(friend, name + " : " + message);
        }

        public void Poke(string who)
        {
            myOpenBook.Poke(who, name);
        }
    }
}
