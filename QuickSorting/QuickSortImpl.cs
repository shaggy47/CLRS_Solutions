using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSorting
{
    class QuickSortImpl
    {
        private int[] collection;

        private void Swap(int i, int j)
        {
            int temp = collection[i];
            collection[i] = collection[j];
            collection[j] = temp;
        }

        private int Partition(int p, int r)
        {
            int i = p - 1;
            int pivote = collection[r];
            for (int j = p; j <= r - 1; j++)
            {
                if (collection[j] <= pivote)
                {
                    i++;
                    Swap(i, j);
                }
            }

            Swap(i + 1, r);
            return i + 1;
        }

        private void QuickSort(int p, int r)
        {
            if (p < r)
            {
                int q = Partition(p, r);
                QuickSort(p, q - 1);
                QuickSort(q + 1, r);
            }
        }

        public QuickSortImpl(int[] arr)
        {
            collection = arr;
        }

        public void Sort()
        {
            QuickSort(0, collection.Length - 1);
        }
    }
}
