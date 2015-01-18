using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class Singleton
    {
        Singleton() { }

        static readonly Singleton instance = new Singleton();

        public static Singleton UniqueInstance
        {
            get
            {
                return instance;
            }
        }
    }
}
