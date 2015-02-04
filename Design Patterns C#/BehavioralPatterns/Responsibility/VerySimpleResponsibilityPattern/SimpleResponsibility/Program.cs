using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Handler start = null;

            for (int i = 5; i > 0; i--)
            {
                Console.WriteLine(" Handler " + i + " deals up to limit " + (i * 1000).ToString());
                start = new Handler(i, start);
            }
            int[] a = { 50, 2000, 1500, 10000, 175, 4500 };

            foreach(int i in a)
            {
                Console.WriteLine(start.HandleRequest(i));
            }
            Console.ReadLine();
        }
    }
}
