using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPractic
{
    public sealed class Aircraft:IAircraft
    {
        int height;
        
        bool airborne;

        public Aircraft()
        {
            height = 0;
            airborne = false;
        }


        public bool Airbone
        {
            get
            {
                return airborne;
            }
        }

        public void TakeOff()
        {
            Console.WriteLine("Aircraft engine takeOff");
            airborne = true;
            height = 200;
        }

        public int Height
        {
            get { return height; }
        }
    }
}
