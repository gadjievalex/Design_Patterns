using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Strategy2:IStrategy
    {
        public int Move(Context c)
        {
            return --c.Counter;
        }
    }
}
