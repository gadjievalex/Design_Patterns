using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateGame
{
    class Context
    {
        public IState State
        {
            get;
            set;
        }

        public void Request(char c)
        {
            string result;

            switch(char.ToLower(c))
            {
                case 'm':
                    result = State.Move(this);
                    break;
                case 'a':
                    result = State.Attack(this);
                    break;
                case 's':
                    result = State.Stop(this);
                    break;
                case 'r':
                    result = State.Run(this);
                    break;
                case 'p':
                    result = State.Panic(this);
                    break;
                case 'c':
                    result = State.CalmDown(this);
                    break;
                case 'e':
                    result = "Thank you playing ";
                    break;
                default:
                    result = "Error try again";
                    break;
            }
            Console.WriteLine(result);
        }
    }
}
