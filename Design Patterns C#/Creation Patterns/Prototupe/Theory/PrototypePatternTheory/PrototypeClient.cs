using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePatternTheory
{
    public class PrototypeClient:IPrototype<Prototype>
    {
        public static void Report(string s, Prototype a, Prototype b)
        {
            Console.WriteLine("\n" + s);
            Console.WriteLine("Prototype " + a + "\nClone " + b);
        }
    }
}
