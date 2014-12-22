using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    public class Client
    {
        public void Display(string s, IComponent c)
        {
            Console.WriteLine(s + c.Operation());
        }
    }
}
