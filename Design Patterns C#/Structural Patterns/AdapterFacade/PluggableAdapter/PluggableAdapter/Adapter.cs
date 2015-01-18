using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluggableAdapter
{
    class Adapter:Adaptee
    {
        public Func<int, string> Request;

        public Adapter(Adaptee adaptee)
        {
            Request = delegate(int i)
            {
                return "Estimate  based on precision is " + (int)Math.Round(Precise(i, 3));
            };
        }
        public Adapter(Target target)
        {
            Request = target.Estimate;
        }
    }
}
