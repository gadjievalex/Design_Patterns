using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPractic
{
    public interface ISeacraft
    {
        int Speed { get; }
        void IncreaseRevs();
    }
}
