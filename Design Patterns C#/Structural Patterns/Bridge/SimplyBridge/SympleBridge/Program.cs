using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SympleBridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bridge Pattern");

            Console.WriteLine(new Abstraction(new ImplementationA()).Operation());
            Console.WriteLine(new Abstraction(new ImplementationB()).Operation());

            Console.ReadLine();
        }
    }
}
