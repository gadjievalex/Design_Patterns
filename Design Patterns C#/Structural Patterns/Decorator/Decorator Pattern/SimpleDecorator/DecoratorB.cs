using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    class DecoratorB:IComponent
    {
        IComponent component;

        public string addedState = "The Coffe Shop";

        public DecoratorB(IComponent c)
        {
            component = c;
        }

        public string Operation()
        {
            string s = component.Operation();

            s += "на мне декоратор - школьная форма " + this + " значит иду в школу ";

            return s;
        }
        public string AddBehaviour()
        {
            return " а возьму-ка Капучино ";
        }
    }
}
