using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMStateMachine.ATMStatePattern
{
    class CardValidateState:ATMState
    {
        public CardValidateState(ATMState state):this(state.DummyCashPresent, state.Atm)
        {

        }

        public CardValidateState(int amountRemaining, ATM atmBeingUsed)
        {
            this.Atm = atmBeingUsed;
            this.DummyCashPresent = amountRemaining;
        }

        public override string GetNextScreen()
        {
            string userInput = Console.ReadLine();
            int requestAmount;
            bool result = Int32.TryParse(userInput, out requestAmount);
            if(result==true)
            {
                if(this.DummyCashPresent<requestAmount)
                {
                    return "Amount not present";
                }
                this.DummyCashPresent -= requestAmount;
                UpdateState();
                return string.Format(@"Amount of {0} has been withddrawn, press ENTER", requestAmount);
            }
            return "Invalid Amount";
        }

        private void UpdateState()
        {
            Atm.currentState = new NoCashState(this);
        }
    }
}
