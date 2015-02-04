using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheoryTemplatedMethod
{
    class Monopoly:GameObject
    {
        protected override void InitializeGame()
        {
            Console.WriteLine("Monopoly initialized");
        }

        protected override void MakePlay(int player)
        {
            Console.WriteLine(string.Format("Making game for {0} players", player));
        }

        protected override bool EndOfGame()
        {
            return true;
        }

        protected override void PrintWinner()
        {
            Console.WriteLine(" Game ended and haw a winner ");
        }
    }
}
