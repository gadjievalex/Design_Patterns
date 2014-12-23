using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealBridgeRealisation
{
    public interface Bridge
    {
        void Add(string message);
        void Add(string friend, string message);
        void Poke(string who);
    }
}
