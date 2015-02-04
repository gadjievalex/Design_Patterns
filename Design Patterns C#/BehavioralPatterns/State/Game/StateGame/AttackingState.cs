using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateGame
{
    class AttackingState:IState
    {
        public override string Move(Context context)
        {
            return "need stop attacking";
        }

        public override string Attack(Context context)
        {
            return "You attack " + (new Random().Next(20) + 1) + " damage";
        }

        public override string Stop(Context context)
        {
            context.State = new RestingState();
            return "you calm down and rest";
        }

        public override string Run(Context context)
        {
            context.State = new MovingState();
            return "you run away";
        }

        public override string Panic(Context context)
        {
            context.State = new PanicState();
            return "you start panic";
        }

        public override string CalmDown(Context context)
        {
            context.State = new RestingState();
            return "you fall down and sleep";
        }
    }
}
