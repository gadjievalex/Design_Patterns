using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodDesign
{
    class ClassB:IPrimitives
    {
        public string Operation1()
        {
            return "Class B:=>op1";
        }

        public string Operation2()
        {
            return "Class B:=>op2";
        }
    }
}
