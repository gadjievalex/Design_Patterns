using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplMenu
{
    public delegate void Invoker();

    static class InvokerExtencion
    {
        static int count;

        public static int Count(this Invoker invoker)
        {
            return count;
        }

        public static void Log(this Invoker invoker)
        {
            count++;
        }
    }
}
