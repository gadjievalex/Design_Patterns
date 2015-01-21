using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BuilderActualExample
{
    class Program
    {
        static void Main(string[] args)
        {
            new Client<Poochy>().ClientMan();
            new Client<Guchi>().ClientMan();

            Console.ReadLine();
        }
        public static void Dowork(string workitem, int time)
        {
            Console.WriteLine("" + workitem + " :0%");
            Thread.Sleep(time);
            Console.WriteLine("...25%");
            Thread.Sleep(time);
            Console.WriteLine("...50%");
            Thread.Sleep(time);
            Console.WriteLine("...100%");
        }
    }
}
