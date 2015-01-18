using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterTheory
{
    class Program
    {
        static void Main(string[] args)
        {
            Adaptee first = new Adaptee();

            Console.WriteLine(" before the new standart\nPrecise reading: ");
            Console.WriteLine(first.SpecificRequest(5, 3));

            ITerget second = new Adapter();

            Console.WriteLine("\nMoving to the new standart");
            Console.WriteLine(second.reguest(5));
        }
    }
}
