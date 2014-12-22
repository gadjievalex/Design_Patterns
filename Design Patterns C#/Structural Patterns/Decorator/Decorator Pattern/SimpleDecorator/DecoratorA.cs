using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    class DecoratorA:IComponent
    {
        IComponent component;
        public DecoratorA(IComponent c)
        {
            component = c;
        }
        public string Operation()
        {
            string s = component.Operation();

            s += string.Format(" а сейчас еще у меня есть декоратор пиджак в его кармане ФМ-радио " + this + " и я слушаю музыку ");

            return s;
        }
    }
}
