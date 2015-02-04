using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankRequest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bank opened");

            foreach(Levels level in Enum.GetValues(typeof(Levels)))
            {
                for (int i = 0; i < Handler.structure[level].Positions; i++)
                {
                    Handler.handlersAtLevels[level].Add(new Handler(i, level));
                }
                Console.WriteLine(Handler.structure[level].Positions + " " + level + "(s) who deal up to limit of " + Handler.structure[level].Limit);
            }
            Console.WriteLine();
            int[] amounts = { 50, 2000, 1500, 10000, 175, 4500, 2000 };
            foreach(int amount in amounts)
            {
                try
                {
                    int wich = Handler.chois.Next(Handler.structure[Levels.Clerk].Positions);
                    Console.WriteLine("Approached clerk " + wich + ". ");
                    Console.WriteLine(Handler.handlersAtLevels[Levels.Clerk][wich].HandleRequest(amount));
                }
                catch(Exception e)
                {
                    Console.WriteLine(" no handle to request " + e.Data["Limit"]);
                }
            }
            Console.ReadKey();
        }
    }
}
