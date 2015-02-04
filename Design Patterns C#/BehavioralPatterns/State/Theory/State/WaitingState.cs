using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class WaitingState:IAutomatState
    {
        private Automat automat;

        public WaitingState(Automat automat)
        {
            this.automat = automat;
        }

        public string GotApplication()
        {
            automat.SetState(automat.GetGotApplicationState());
            return "Thanks for the application";
        }

        public string CheckApplication()
        {
            return "You have to submit an application";
        }

        public string RentApplication()
        {
            return "You have to submit an application";
        }

        public string DispenseKeys()
        {
            return "You have to submit an application";
        }
    }
}
