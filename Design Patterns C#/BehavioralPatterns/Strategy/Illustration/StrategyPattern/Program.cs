using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            context.SwitchStrategy();
            Random r = new Random(37);

            for (int i = Context.start; i <= Context.start + 15; i++)
            {
                if(r.Next(3)==2)
                {
                    Console.Write("||");
                    Thread.Sleep(250);
                    context.SwitchStrategy();
                }
                Console.Write(context.Algorithm() + " ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
