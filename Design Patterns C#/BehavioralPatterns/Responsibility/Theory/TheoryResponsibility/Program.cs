using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheoryResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Handler h1 = new ConcreteHandler1();
            Handler h2 = new ConcreteHandler2();
            Handler h3 = new ConcreteHandler3();

            h1.SetSuccessor(h2);
            h2.SetSuccessor(h3);

            int[] requests = { 1, 2, 3, 4, 14, 15, 66, 20, 27, 3 };

            foreach (int request in requests)
            {
                h1.HandleRequest(request);
            }

            Console.ReadKey();
        }
    }
}
