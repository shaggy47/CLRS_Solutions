using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapAndHeapSort
{
    class MinHeap
    {

        private int size;
        private int[] collection;

        private int Parent(int index)
        {
            if (index == 0)
                return -1;

            return (index - 1) / 2;
        }

        private int Left(int index)
        {
            return (2 * index) + 1;
        }

        private int Right(int index)
        {
            return (2 * index) + 2;
        }

        private void Swap(int i, int j)
        {
            int temp = collection[i];
            collection[i] = collection[j];
            collection[j] = temp;
        }

        private bool HasParent(int index)
        {
            if (Parent(index) >= 0)
                return true;
            else
                return false;
        }

        private void HeapifyUp(int index)
        {
            while (HasParent(index) && collection[index] < collection[Parent(index)])
            {
                Swap(index, Parent(index));
                index = Parent(index);
            }
        }

        private void MinHeapify(int i, int s)
        {
            int l = 2 * i + 1;
            int r = 2 * i + 2;
            int smallest = i;
            if (l < s && collection[l] < collection[smallest])
                smallest = l;

            if (r < s && collection[r] < collection[smallest])
                smallest = r;

            if (smallest != i)
            {
                Swap(i, smallest);
                MinHeapify(smallest, s);
            }
        }

        public MinHeap()
        {
            collection = new int[10];
            this.size = 0;
        }

        public void Add(int item)
        {

            if (size == collection.Length)
            {
                int[] temp = new int[size * 2];
                Array.Copy(collection, temp, collection.Length);
                collection = temp;
            }

            collection[size] = item;
            HeapifyUp(size);
            size++;
        }

        

        public void Delete(int item)
        {
            int toDelete = -1;
            for (int i = 0; i < size; i++)
            {
                if (collection[i] == item)
                {
                    toDelete = i;
                    break;
                }
            }

            if (toDelete != -1)
            {
                int lastNode = size - 1;
                collection[toDelete] = int.MinValue;
                Swap(toDelete, lastNode);
                size--;
                MinHeapify(toDelete, size);
            }

        }

        public void PrintMin()
        {
            Console.WriteLine(collection[0]);
        }
    }
}
