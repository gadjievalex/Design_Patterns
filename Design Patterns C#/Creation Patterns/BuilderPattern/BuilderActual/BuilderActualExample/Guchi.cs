using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderActualExample
{
    class Guchi:IBrand
    {
        public IBag CreateBag()
        {
            Bag b = new Bag();
            Program.Dowork(" C Leather ", 2500);
            Program.Dowork(" S Leather ", 1000);
            b.Properties += "Leather";
            Program.Dowork(" Lining ", 500);
            Program.Dowork(" Attach Linning ", 1000);
            b.Properties += "Linning";
            Program.Dowork("Add label", 250);
            b.Properties += "Label";

            return b;
        }
    }
}
