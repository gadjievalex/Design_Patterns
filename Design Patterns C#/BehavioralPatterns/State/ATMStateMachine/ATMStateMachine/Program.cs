using ATMStateMachine.ATMStatePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMStateMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            TestWithStatePattern();
            //TestWithoutStatePattern();
        }

        private static void TestWithoutStatePattern()
        {
            //NoStateATM atm = new NoStateATM();

            //while(true)
            //{
            //    Console.WriteLine(atm.GetNextScreen());
            //}
        }

        private static void TestWithStatePattern()
        {
            ATM atm = new ATM();
            atm.Start();
        }
    }
}
