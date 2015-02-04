using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleState
{
    class NormalState:IState
    {
        public int MoveUP(Context context)
        {
            context.Counter += 2;
            return context.Counter;
        }

        public int MoveDown(Context context)
        {
            if (context.Counter < Context.limit)
            {
                context.State = new FastState();
                Console.WriteLine("||");
            }
            context.Counter -= 2;
            return context.Counter;
        }
    }
}
