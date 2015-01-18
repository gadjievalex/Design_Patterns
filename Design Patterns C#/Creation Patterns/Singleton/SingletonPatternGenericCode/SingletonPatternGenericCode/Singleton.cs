using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternGenericCode
{
    public class Singleton<T>where T:class, new()
    {
        Singleton() { }
        class SingletonCreator
        {
            static SingletonCreator() { }
            internal static readonly T instance = new T();
        }

        public static T UniqueInstance
        {
            get
            {
                return SingletonCreator.instance;
            }
        }
    }
}
