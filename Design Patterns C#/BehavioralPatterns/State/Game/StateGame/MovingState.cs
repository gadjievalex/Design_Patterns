using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateGame
{
    class MovingState:IState
    {
        public override string Move(Context context)
        {
            return "you move around randomly";
        }

        public override string Attack(Context context)
        {
            return "You need stop first";
        }

        public override string Stop(Context context)
        {
            context.State = new RestingState();
            return "you stand in a dark";
        }

        public override string Run(Context context)
        {
            return "you run around in circles";
        }

        public override string Panic(Context context)
        {
            context.State = new PanicState();
            return "you start panic and seeng things";
        }

        public override string CalmDown(Context context)
        {
            context.State = new RestingState();
            return "you stand still and relax";
        }
    }
}
