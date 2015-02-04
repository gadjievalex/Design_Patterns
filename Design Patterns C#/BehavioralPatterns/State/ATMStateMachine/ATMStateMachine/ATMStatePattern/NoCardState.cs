using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMStateMachine.ATMStatePattern
{
    class NoCardState:ATMState
    {
        public NoCardState(ATMState state):this(state.DummyCashPresent, state.Atm)
        {

        }

        public NoCardState(int amountRemaining, ATM atmBeingUsed)
        {
            this.Atm = atmBeingUsed;
            this.DummyCashPresent = amountRemaining;
        }

        public override string GetNextScreen()
        {
            Console.WriteLine("Please enter your PIN");
            string userInput = Console.ReadLine();

            if (userInput.Trim() == "12345")
            {
                UpdateState();
                return "Enter the Amount to Withdraw";
            }
            return "Invalid PIN";
        }

        private void UpdateState()
        {
            Atm.currentState = new CardValidateState(this);
        }
    }
}
