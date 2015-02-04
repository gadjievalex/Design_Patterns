using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheoryTemplatedMethod
{
    abstract class GameObject
    {
        protected int PlayerCount;

        abstract protected bool EndOfGame();

        abstract protected void InitializeGame();

        abstract protected void MakePlay(int player);

        abstract protected void PrintWinner();

        public void PlayOneGame(int playersCount)
        {
            PlayerCount = playersCount;

            InitializeGame();

            var j = 0;

            while(!EndOfGame())
            {
                MakePlay(j);
                j = (j + 1) % playersCount;
            }
            PrintWinner();
        }
    }
}
