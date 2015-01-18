using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeExamole
{
    public static class Facade
    {
        static SubsystemA a = new SubsystemA();
        static SubsystemB b = new SubsystemB();
        static SubsystemC c = new SubsystemC();

        public static void Operation1()
        {
            Console.WriteLine("Opeartion 1" + a.A1() + " " + a.A2() + " " + b.B1());
        }

        public static void Operation2()
        {
            Console.WriteLine("Operation 2" + b.B1() + " " + c.C1());
        }
    }
}
