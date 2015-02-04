using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAnimator
{
    static class StartSetGenerator
    {
        private static List<int> myList;

        public static IEnumerable<int>GetStartSet()
        {
            const int n = 200;

            if(myList==null)
            {
                List<int> list = new List<int>();
                Random ranomGenerator = new Random();
                List<int> range = new List<int>();

                for (int i = 0; i < n; i++)
                {
                    range.Add(i);
                }
                while(range.Count>0)
                {
                    int item = range[ranomGenerator.Next(range.Count)];
                    list.Add(item);
                    range.Remove(item);
                }
                myList = list;
            }
            return myList;
        }
    }
}
