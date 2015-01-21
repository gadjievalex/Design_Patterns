using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderActualExample
{
    class Poochy:IBrand
    {
        public IBag CreateBag()
        {
            Bag b = new Bag();
            Program.Dowork(" Labour ", 200);
            Program.Dowork(" Plastic ", 125);
            Program.Dowork(" Plastic ", 500);
            b.Properties += "Plastic";
            Program.Dowork("Label", 100);
            b.Properties += "Label";
            return b;
        }
    }
}
