using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            Algorithm m = new Algorithm();

            m.TemplateMethod(new ClassA());
            m.TemplateMethod(new ClassB());

            Console.ReadLine();
        }
    }
}
