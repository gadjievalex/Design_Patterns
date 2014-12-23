using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealBridgeRealisation
{
    class Program
    {
        static void Main(string[] args)
        {
            Portal me = new Portal(new MyOpenBook("Judith"));

            me.Add("Hello world");
            me.Add("Today i worked 18 hours");

            Portal tom = new Portal(new MyOpenBook("Tom"));

            tom.Poke("Judith - 1");

            tom.SuperPoke("Judith - 1", "hugged");
            tom.Add("Judith - 1", "Poor you");
            tom.Add("Hey, Im on OpenBoock - its Cool!");

            Console.ReadLine();
        }
    }
}
