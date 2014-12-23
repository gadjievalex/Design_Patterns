using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealProxyExample
{
    class Program
    {
        static void Main(string[] args)
        {
            MySpaceBook me = new MySpaceBook();

            me.Add("Hello world");
            me.Add("Today i worked 18 hours");

            MySpaceBook tom = new MySpaceBook();

            tom.Poke("Judith");

            tom.Add("Justin", "Poor you");

            tom.Add("Off to see the Lion King tonight");

            Console.ReadLine();
        }
    }
}
