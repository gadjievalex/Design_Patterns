using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMStateMachine.ATMStatePattern
{
    class ATM
    {
        public ATMState currentState = null;

        public ATM()
        {
            currentState = new NoCardState(1000, this);
        }

        public void Start()
        {
            while(true)
            {
                Console.WriteLine(currentState.GetNextScreen());
            }
        }
    }
}
