using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAnimator
{
    class MergeSorter<T>:SortStrategy<T>where T:IComparable<T>
    {
        public event Action<IEnumerable<T>> UpdateUI;

        List<T> aux;

        int opCount = 0;

        public void Sort(IEnumerable<T>input)
        {
            UpdateUI(input);
            opCount++;
            List<T> sorteditems = new List<T>(input);
            aux = new List<T>(sorteditems.Count);

            for (int i = 0; i < sorteditems.Count; i++)
            {
                aux.Add(default(T));
            }

            MergeSort(ref sorteditems, 0, sorteditems.Count - 1);
            UpdateUI(sorteditems);
        }

        private void Merge(ref List<T>a, int l, int m, int r)
        {
            int i;
            int j;

            for (i = m + 1; i > l; i--)
            {

            }
        }

        private void MergeSort(ref List<T>a, int l, int r)
        {
            if(r <= l)
            {
                return;
            }
            int m = (r + l) / 2;
            MergeSort(ref a, l, m);
            if (opCount > 50) 
            {
                UpdateUI(a);
                opCount = opCount - 50;
            }
            MergeSort(ref a, m + 1, r);
            if (opCount > 50)
            {
                UpdateUI(a);
                opCount = opCount - 50;
            }
            Merge(ref a, l, m, r);
            if(opCount>50)
            {
                UpdateUI(a);
                opCount = opCount - 50;
            }
        }
    }
}
