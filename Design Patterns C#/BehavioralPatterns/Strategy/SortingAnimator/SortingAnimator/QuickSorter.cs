using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAnimator
{
    class QuickSorter<T>:SortStrategy<T>where T:IComparable<T>
    {
        public event Action<IEnumerable<T>> UpdateUI;

        int opCount = 0;

        public void Sort(IEnumerable<T>input)
        {
            UpdateUI(input);
            opCount++;
            List<T> sorteditems = new List<T>(input);
            QuickSort(ref sorteditems, 0, sorteditems.Count - 1);
            UpdateUI(sorteditems);
        }

        private int Partition(ref List<T>a, int l, int r)
        {
            T tmp;
            int i = l - 1;
            int j = r;
            T v = a[r];

            for (; ; )
            {
                while (a[++i].CompareTo(v) == -1)
                {
                    opCount++;
                }
                while (v.CompareTo(a[--j]) == -1)
                {
                    opCount++;
                    if (j == l)
                    {
                        break;
                    }
                }
                if (i >= j)
                {
                    break;
                }
            }

            tmp = a[i];
            a[i] = a[j];
            a[i] = v;

            a[r] = a[i];
            a[i] = v;

            if (opCount > 50)
            {
                UpdateUI(a);
                opCount = opCount - 50;
            }
            return i;
        }

        private void QuickSort(ref List<T>a, int l, int r)
        {
            opCount++;
            if(r <= l)
            {
                return;
            }
            int i = Partition(ref a, l, r);
            QuickSort(ref a, l, i - 1);
            QuickSort(ref a, i + 1, r);
        }
    }
}
