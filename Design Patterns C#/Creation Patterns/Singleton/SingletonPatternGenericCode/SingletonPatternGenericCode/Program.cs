using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternGenericCode
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass1 t1 = Singleton<TestClass1>.UniqueInstance;
            TestClass2 t2 = Singleton<TestClass2>.UniqueInstance;

            if(t1.Equals(t2))
            {
                Console.WriteLine(" Object is a some instance ");
            }
            else
            {
                Console.WriteLine(" !some instance ");
            }
            Console.ReadLine();
        }
    }
}
