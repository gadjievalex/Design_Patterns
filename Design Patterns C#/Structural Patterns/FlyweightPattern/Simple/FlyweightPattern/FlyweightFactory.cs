using System.Collections.Generic;

namespace FlyweightPattern
{
    class FlyweightFactory
    {
        Dictionary<string, IFlyweight> flyweight = new Dictionary<string, IFlyweight>();

        public FlyweightFactory()
        {
            flyweight.Clear();
        }

        public IFlyweight this[string index]
        {
            get
            {
                if(!flyweight.ContainsKey(index))
                {
                    flyweight[index] = new Flyweight();
                }
                return flyweight[index];
            }
        }
    }
}
