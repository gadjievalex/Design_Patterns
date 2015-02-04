using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheoryTemplatedMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            GameObject game = new Monopoly();
            game.PlayOneGame(2);
            game = new Chess();
            game.PlayOneGame(2);
            Console.ReadLine();
        }
    }
}
