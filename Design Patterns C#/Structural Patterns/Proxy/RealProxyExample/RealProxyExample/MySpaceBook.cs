using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealProxyExample
{
    public class MySpaceBook
    {
        SpaceBook mySpaceBook;

        string password;

        string name;

        bool loggedIn = false;

        void Register()
        {
            Console.WriteLine("Register you to SpaceBook");

            do
            {
                Console.WriteLine("All SpaceBooks names must be unique");
                Console.WriteLine("Type in a user name");

                name = Console.ReadLine();
            }
            while (SpaceBook.IsUnique(name));

            Console.WriteLine("Type a password");

            password = Console.ReadLine();

            Console.WriteLine("Thansk for registering with SpaceBook");
        }

        bool Authenticate()
        {
            Console.WriteLine("Welkome " + name + " please type your password");

            string supplied = Console.ReadLine();

            if(supplied==password)
            {
                loggedIn = true;

                Console.WriteLine("You logged into");

                if(mySpaceBook==null)
                {
                    mySpaceBook = new SpaceBook(name);
                }
                return true;
            }
            Console.WriteLine("Incorrect password");

            return false;
        }

        public void Add(string message)
        {
            Check();
            
            if(loggedIn)
            {
                mySpaceBook.Add(message);
            }
        }

        public void Add(string friend, string message)
        {
            Check();

            if(loggedIn)
            {
                mySpaceBook.Add(friend, name + "said: " + message);
            }
        }

        public void Poke(string who)
        {
            Check();

            if(loggedIn)
            {
                mySpaceBook.Poke(who, name);
            }
        }

        void Check()
        {
            if(!loggedIn)
            {
                if(password==null)
                {
                    Register();
                }
                if(mySpaceBook==null)
                {
                    Authenticate();
                }
            }
        }
    }
}
