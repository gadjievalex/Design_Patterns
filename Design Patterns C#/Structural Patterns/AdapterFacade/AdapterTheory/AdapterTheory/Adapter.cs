using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterTheory
{
    class Adapter:Adaptee, ITerget
    {
        public string reguest(int i)
        {
            return "Rought estimate is" + (int)Math.Round(SpecificRequest(i, 3));
        }
    }
}
