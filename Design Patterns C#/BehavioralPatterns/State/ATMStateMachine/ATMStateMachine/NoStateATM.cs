using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMStateMachine
{
    class NoStateATM
    {
        public enum MACHINE_STATE
        {
            NO_CARD,
            CARDS_VALIDATED,
            CASH_WITHDRAWN,
        }

        private MACHINE_STATE currentState = MACHINE_STATE.NO_CARD;
        private int dummyCashPresent = 1000;

        public string GetNextScreen()
        {
            switch(currentState)
            {
                case MACHINE_STATE.NO_CARD:
                    return GetPinValidated();
                    break;

                case MACHINE_STATE.CARDS_VALIDATED:
                    return WithdrawMoney();
                    break;

                case MACHINE_STATE.CASH_WITHDRAWN:
                    return SayGoodBye();
                    break;
            }
            return string.Empty;
        }

        private string GetPinValidated()
        {
            Console.WriteLine("Please Enter your PIN");
            string userInput = Console.ReadLine();
            if (userInput.Trim() == "12345")
            {
                currentState = MACHINE_STATE.CARDS_VALIDATED;
                return "Enter Amount to Widthdraw";
            }
            return "Invalid PIN";
        }

        private string WithdrawMoney()
        {
            string userInput = Console.ReadLine();
            int requestAmount;
            bool result = Int32.TryParse(userInput, out requestAmount);

            if(result==true)
            {
                if (dummyCashPresent < requestAmount)
                {
                    return "Amount not present";
                }
                dummyCashPresent -= requestAmount;
                currentState = MACHINE_STATE.CASH_WITHDRAWN;
                return string.Format(@"Amount of {0} has been withdrawn. press enter to proceed", requestAmount);
            }
            return "Invalid Amount";
        }

        private string SayGoodBye()
        {
            currentState = MACHINE_STATE.NO_CARD;
            return string.Format("Thanks for using us. Amount left in ATM {0} ", dummyCashPresent.ToString());
        }
    }
}
