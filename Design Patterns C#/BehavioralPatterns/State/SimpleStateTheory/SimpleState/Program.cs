using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleState
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            context.State = new NormalState();
            Random r = new Random(37);

            for (int i = 5; i <= 25; i++)
            {
                int command = r.Next(3);
                Console.WriteLine(context.Request(command) + " ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
