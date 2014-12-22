using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    class Component:IComponent
    {
        public string Operation()
        {
            return string.Format(" я просто компонент - я просто иду ");
        }
    }
}
