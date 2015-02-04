using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class GotApplicationState:IAutomatState
    {
        private Automat automat;
        private readonly Random random;

        public GotApplicationState(Automat automat)
        {
            this.automat = automat;
            random = new Random(System.DateTime.Now.Millisecond);
        }

        public string GotApplication()
        {
            return "Your appliction is got";
        }

        public string CheckApplication()
        {
            var yesno = random.Next() % 10;

            if (yesno > 4 && automat.Count > 0)
            {
                automat.SetState(automat.GetApartmentRentState());
                return "You were approved";
            }
            else
            {
                automat.SetState(automat.GetWaitingState());
                return "you not approved";
            }
        }

        public string RentApplication()
        {
            return "Your appliction is got";
        }

        public string DispenseKeys()
        {
            return "Your appliction is got";
        }
    }
}
