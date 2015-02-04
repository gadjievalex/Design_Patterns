using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class FullyRenteState:IAutomatState
    {
        private Automat automat;

        public FullyRenteState(Automat automat)
        {
            this.automat = automat;
        }

        public string GotApplication()
        {
            return "fully rented";
        }

        public string CheckApplication()
        {
            return "fully rented";
        }

        public string RentApplication()
        {
            return "fully rented";
        }

        public string DispenseKeys()
        {
            return "fully rented";
        }
    }
}
