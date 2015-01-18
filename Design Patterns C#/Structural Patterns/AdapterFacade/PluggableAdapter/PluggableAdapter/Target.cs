using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluggableAdapter
{
    class Target
    {
        public string Estimate(int i)
        {
            return "Estimate is" + (int)Math.Round(i / 3.0);
        }
    }
}
