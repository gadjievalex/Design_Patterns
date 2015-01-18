﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluggableAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Adapter adapter1 = new Adapter(new Adaptee());

            Console.WriteLine(adapter1.Request(5));

            Adapter adapter2 = new Adapter(new Target());

            Console.WriteLine(adapter2.Request(5));

            Console.ReadLine();
        }
    }
}
