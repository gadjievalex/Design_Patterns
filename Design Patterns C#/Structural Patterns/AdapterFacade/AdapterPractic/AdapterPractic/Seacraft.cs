using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPractic
{
    public class Seacraft:ISeacraft
    {
        public int speed = 0;

        public int Speed
        {
            get { return speed; }
        }

        public virtual void IncreaseRevs()
        {
            speed += 10;
            Console.WriteLine("Seacraft engine increases revs to " + speed + " knots ");
        }
    }
}
