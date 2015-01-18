using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class ProductB:Iproduct
    {
        public string ShipForm()
        {
            return "From Spain";
        }
    }
}
