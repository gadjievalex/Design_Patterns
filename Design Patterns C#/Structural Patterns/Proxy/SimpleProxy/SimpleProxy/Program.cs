using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Proxy pattern");

            ISubject subject = new Proxy();

            Console.WriteLine(subject.Request());
            Console.WriteLine(subject.Request());

            ProtectionProxy protectsubject = new ProtectionProxy();

            Console.WriteLine(subject.Request());
            Console.WriteLine((protectsubject as ProtectionProxy).Authenticate("Secret"));
            Console.WriteLine((protectsubject as ProtectionProxy).Authenticate("Abrakadabra"));

            Console.WriteLine(subject.Request());

            Console.ReadKey();
        }
    }
}
