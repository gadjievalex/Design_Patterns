using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonLazyInstantiation
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = new Singleton();

            Console.ReadLine();
        }
    }
}
