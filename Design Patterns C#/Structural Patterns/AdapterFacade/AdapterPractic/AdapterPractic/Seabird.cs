using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPractic
{
    class Seabird:Seacraft, IAircraft
    {
        int height = 0;

        public void TakeOff()
        {
            while(!Airbone)
            {
                IncreaseRevs();
            }
        }

        public int Height
        {
            get { return height; }
        }

        public void IncreaseRevs()
        {
            base.IncreaseRevs();

            if (Speed > 40)
            {
                height += 100;
            }
        }

        public bool Airbone
        {
            get { return height > 50; }
        }
    }
}
