using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateGame
{
    class PanicState:IState
    {
        public override string Move(Context context)
        {
            return "run around randomly in a blind panic";
        }

        public override string Attack(Context context)
        {
            return "you attack the darkness";
        }

        public override string Stop(Context context)
        {
            context.State = new MovingState();
            return "you start re;axing but keep on moving";
        }

        public override string Run(Context context)
        {
            return "you run around in a panic";
        }

        public override string Panic(Context context)
        {
            return "you already in a panic";
        }

        public override string CalmDown(Context context)
        {
            context.State = new RestingState();
            return "you relaxing";
        }
    }
}
