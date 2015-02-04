using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMStateMachine.ATMStatePattern
{
    class NoCashState:ATMState
    {
        public NoCashState(ATMState state):this(state.DummyCashPresent, state.Atm)
        {

        }

        public NoCashState(int amountRemainig, ATM atmBeingUsed)
        {
            this.Atm = atmBeingUsed;
            this.DummyCashPresent = amountRemainig;
        }

        public override string GetNextScreen()
        {
            Console.ReadLine();
            UpdateState();
            return string.Empty;
        }

        public void UpdateState()
        {
            Atm.currentState = new NoCardState(this);
        }
    }
}
