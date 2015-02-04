using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Automat:IAutomat
    {
        private IAutomatState waitingState;
        private IAutomatState gotApplicationState;
        private IAutomatState appartmentRentedState;
        private IAutomatState fullyRentedState;
        private IAutomatState state;
        private Int32 count;

        public Automat(Int32 n)
        {
            count = n;
            waitingState = new WaitingState(this);
            gotApplicationState = new GotApplicationState(this);
            appartmentRentedState = new ApartmentRentedState(this);
            fullyRentedState = new FullyRenteState(this);
            state = waitingState;
        }

        public void GotApplication()
        {
            Console.Write(state.GotApplication());
        }

        public void CheckApplication()
        {
            Console.WriteLine(state.CheckApplication());
        }

        public void RentApplication()
        {
            Console.WriteLine(state.RentApplication());
            Console.WriteLine(state.DispenseKeys());
        }

        public void SetState(IAutomatState s)
        {
            state = s;
        }

        public IAutomatState GetWaitingState()
        {
            return waitingState;
        }

        public IAutomatState GetGotApplicationState()
        {
            return gotApplicationState;
        }

        public IAutomatState GetApartmentRentState()
        {
            return appartmentRentedState;
        }

        public IAutomatState GetFullyRentedState()
        {
            return fullyRentedState;
        }

        public int Count
        {
            get
            {
                return count;
            }
            set
            {
                count = value;
            }
        }
    }
}
