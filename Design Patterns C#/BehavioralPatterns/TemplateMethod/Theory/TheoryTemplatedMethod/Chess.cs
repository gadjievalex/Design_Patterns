using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheoryTemplatedMethod
{
    class Chess:GameObject
    {
        protected override bool EndOfGame()
        {
            return true;
        }

        protected override void InitializeGame()
        {
            Console.WriteLine("Chess initialized");
        }

        protected override void MakePlay(int player)
        {
            Console.WriteLine(" Chess game created for {0} players", player);
        }

        protected override void PrintWinner()
        {
            Console.WriteLine("Game haw winner");
        }
    }
}
