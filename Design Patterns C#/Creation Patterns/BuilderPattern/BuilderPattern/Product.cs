using System;
using System.Collections.Generic;

namespace BuilderPattern
{
    class Product
    {
        List<string> parts = new List<string>();

        public void Add(string part)
        {
            parts.Add(part);
        }

        public void Display()
        {
            Console.WriteLine(" Product Parts ");

            foreach(string part in parts)
            {
                Console.WriteLine(part + " <<< - part ");
            }
            Console.WriteLine(" ");
        }
    }
}
