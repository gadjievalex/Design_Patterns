﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePatternTheory
{
    [Serializable()]
    class PrototypeManager:IPrototype<Prototype>
    {
        public Dictionary<string, Prototype> prototypes = new Dictionary<string, Prototype>
        {
            {"Germany",new Prototype("Germany","Berlin","German")},
            {"Italy",new Prototype("Italy","Rome","Italian")},
            {"Australia",new Prototype("Australia","Canberra","English")},
        };
    }
}
