using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();

            B b = new B();

            C c = new C();

            D d = new D();

            F f = new F();

            a.call("piupiu");

            b.call("piupiu");

            c.call("piupiu");

            d.call("piupiu");

            Console.ReadLine();
        }
    }
}
