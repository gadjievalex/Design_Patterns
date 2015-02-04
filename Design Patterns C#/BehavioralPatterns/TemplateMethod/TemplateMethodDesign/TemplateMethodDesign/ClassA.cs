using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodDesign
{
    class ClassA:IPrimitives
    {
        public string Operation1()
        {
            return "Class A:=>op1";
        }

        public string Operation2()
        {
            return "Class A:=>op2";
        }
    }
}
