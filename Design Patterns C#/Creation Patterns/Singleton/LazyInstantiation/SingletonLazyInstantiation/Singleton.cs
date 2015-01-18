using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonLazyInstantiation
{
    public class Singleton
    {
        Singleton()
        {

        }
        class SingletonCreator
        {
            static SingletonCreator() { }

            internal static readonly Singleton uniqueInstance = new Singleton();

            public static Singleton UniqueInstance
            {
                get
                {
                    return SingletonCreator.uniqueInstance;
                }
            }
        }
    }
}
