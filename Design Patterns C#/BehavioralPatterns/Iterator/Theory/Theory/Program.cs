using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theory
{
    class Program
    {
        static void Main(string[] args)
        {
            MonthCollection collection = new MonthCollection();

            foreach(string n in collection)
            {
                Console.Write(n + " ");
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}
