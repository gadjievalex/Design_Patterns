using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Strategy1:IStrategy
    {
        public int Move(Context c)
        {
            return ++c.Counter;
        }
    }
}
