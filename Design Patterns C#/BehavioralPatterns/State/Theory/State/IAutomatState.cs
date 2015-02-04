using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    interface IAutomatState
    {
        String GotApplication();
        String CheckApplication();
        String RentApplication();
        String DispenseKeys();
    }
}
