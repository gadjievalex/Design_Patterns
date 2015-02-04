using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            var automat = new Automat(9);

            automat.GotApplication();
            automat.CheckApplication();
            automat.RentApplication();

            Console.ReadLine();
        }
    }
}
