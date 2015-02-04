using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    interface IAutomat
    {
        void GotApplication();
        void CheckApplication();
        void RentApplication();

        void SetState(IAutomatState s);
        IAutomatState GetWaitingState();
        IAutomatState GetGotApplicationState();
        IAutomatState GetApartmentRentState();
        IAutomatState GetFullyRentedState();

        Int32 Count { get; set; }
    }
}
