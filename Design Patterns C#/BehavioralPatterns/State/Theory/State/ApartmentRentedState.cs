using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class ApartmentRentedState:IAutomatState
    {
        private Automat automat;

        public ApartmentRentedState(Automat automat)
        {
            this.automat = automat;
        }

        public string GotApplication()
        {
            return "renting";
        }

        public string CheckApplication()
        {
            return "renting";
        }

        public string RentApplication()
        {
            automat.Count = automat.Count - 1;
            return "renting";
        }

        public string DispenseKeys()
        {
            if (automat.Count <= 0)
            {
                automat.SetState(automat.GetFullyRentedState());
            }
            else
            {
                automat.SetState(automat.GetWaitingState());
            }
            return "your keys";
        }
    }
}
