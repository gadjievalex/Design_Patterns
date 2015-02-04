
namespace StateGame
{
    class RestingState:IState
    {
        public override string Move(Context context)
        {
            context.State = new MovingState();
            return "start moving";
        }

        public override string Attack(Context context)
        {
            context.State = new AttackingState();
            return "start attack";
        }

        public override string Stop(Context context)
        {
            return "stoping";
        }

        public override string Run(Context context)
        {
            return "moving";
        }

        public override string Panic(Context context)
        {
            context.State = new PanicState();
            return "start panic";
        }

        public override string CalmDown(Context context)
        {
            return "you relaxing";
        }
    }
}
