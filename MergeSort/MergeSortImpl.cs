using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class MergeSortImpl
    {
        int[] array;
        public MergeSortImpl(int[] arr)
        {
            this.array = arr;
        }

        public void SortIterative()
        {
            IterativeSort();
        }

        public void Sort()
        {
            MergeSort(0, array.Length - 1);
        }

        private int min(int a, int b)
        {
            return a < b ? a : b;
        }

        private void IterativeSort()
        {
            for (int size = 1; size < array.Length; size = size * 2)
            {
                for (int l = 0; l < array.Length; l += size * 2)
                {
                    int mid = l + size - 1;
                    int r = min(l + 2 * (size - 1), array.Length - 1);
                    //Merge(l, mid, r);
                }
            }
        }

        private void MergeSort(int p, int r)
        {
            if (p < r)
            {
                int mid = (r + p) / 2;
                MergeSort(p, mid);
                MergeSort(mid + 1, r);
                Merge(p, mid, r);
            }
        }

        public void Merge(int p, int q, int r)
        {
            int n1 = q - p + 1;
            int n2 = r - q;

            int[] L = new int[n1];
            int[] R = new int[n2];

            // Split the array into two arrays.
            for (int i = 0; i < n1; i++)
                L[i] = array[p + i];
            for (int i = 0; i < n2; i++)
                R[i] = array[q + 1 + i];


            //Merge 
            int ll = 0, rr = 0;
            int idx = p;
            while (ll < n1 && rr < n2)
            {
                if (L[ll] < R[rr])
                {
                    array[idx] = L[ll];
                    ll++;
                }
                else
                {
                    array[idx] = R[rr];
                    rr++;
                }

                idx++;
            }

            while (ll < n1)
            {
                array[idx] = L[ll];
                ll++;
                idx++;
            }

            while (rr < n2)
            {
                array[idx] = L[rr];
                rr++;
                idx++;
            }
        }
    }
}
