using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPractic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Experiment 1 test aircraft engine");

            IAircraft aircraft = new Aircraft();
            
            aircraft.TakeOff();

            if(aircraft.Airbone)
            {
                Console.WriteLine("The aircraft engine is fine flying at " + aircraft.Height + " meters ");
            }
            Console.WriteLine("Experiment 2 use the engine in the seabird");

            IAircraft seabird = new Seabird();

            seabird.TakeOff();

            Console.WriteLine("\nthe seabird take off ");

            Console.WriteLine("\nExperiment 3 increase the speed Seabird");

            (seabird as ISeacraft).IncreaseRevs();
            (seabird as ISeacraft).IncreaseRevs();

            if(seabird.Airbone)
            {
                Console.WriteLine("Seabird flying at height " + seabird.Height + " meters and speed " + (seabird as ISeacraft).Speed + " knots");
            }
            Console.WriteLine("Experiment succesful the seabird flies");

            Console.ReadLine();
        }
    }
}
