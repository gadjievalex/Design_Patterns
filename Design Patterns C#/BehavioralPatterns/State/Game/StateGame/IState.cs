
namespace StateGame
{
    abstract class IState
    {
        public virtual string Move(Context context)
        {
            return "";
        }

        public virtual string Attack(Context context)
        {
            return "";
        }

        public virtual string Stop(Context context)
        {
            return "";
        }

        public virtual string Run(Context context)
        {
            return "";
        }

        public virtual string Panic(Context context)
        {
            return "";
        }

        public virtual string CalmDown(Context context)
        {
            return "";
        }
    }
}
