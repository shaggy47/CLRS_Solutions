using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapAndHeapSort
{
    public class Heap
    {
        private HeapType heapType;
        private int[] collection;
        private int currentSize;
        private int root;

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

        private void HeapifyUp(int index)
        {
            while (HasParent(index) && collection[index] < collection[Parent(index)])
            {
                Swap(index, Parent(index));
                index = Parent(index);
            }
        }

        public void ItrHeapify(int i)
        {
            while (true)
            {
                int l = 2 * i + 1;
                int r = 2 * i + 2;
                int largest = i;
                if (l < collection.Length && collection[l] >= collection[largest])
                    largest = l;

                if (r < collection.Length && collection[r] >= collection[largest])
                    largest = r;

                if (largest == i)
                    break;

                Swap(i, largest);
                i = largest;
            }
        }

        private bool HasParent(int index)
        {
            if (Parent(index) >= 0)
                return true;
            else
                return false;
        }


        private void Swap(int i, int j)
        {
            int temp = collection[i];
            collection[i] = collection[j];
            collection[j] = temp;
        }

        public Heap(int[] arr, HeapType heapType, int size)
        {
            this.heapType = heapType;
            collection = arr;
            this.currentSize = 0;
            this.root = 0;
            BuildHeap();
        }

        public Heap(int[] arr)
        {
            this.collection = arr;
            this.root = 0;
        }

        public void BuildHeap()
        {
            if (this.heapType == HeapType.Max)
            {
                for (int i = collection.Length / 2 - 1; i >= root; i--)
                {
                    Heapify(i);
                }
            }
            else
            {
                for (int i = collection.Length / 2 - 1; i >= root; i--)
                {
                    MinHeapify(i);
                }
            }

        }

        public void Print()
        {
            foreach (var item in this.collection)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        private void Heapify(int i)
        {
            int l = 2 * i + 1;
            int r = 2 * i + 2;
            int largest = i;
            if (l < collection.Length && collection[l] >= collection[largest])
                largest = l;

            if (r < collection.Length && collection[r] >= collection[largest])
                largest = r;

            if (largest != i)
            {
                Swap(i, largest);
                Heapify(largest);
            }
        }

        private void MinHeapify(int i)
        {
            int l = 2 * i + 1;
            int r = 2 * i + 2;
            int smallest = i;
            if (l < collection.Length && collection[l] < collection[smallest])
                smallest = l;

            if (r < collection.Length && collection[r] < collection[smallest])
                smallest = r;

            if (smallest != i)
            {
                Swap(i, smallest);
                MinHeapify(smallest);
            }
        }

        private bool HasLeft(int i)
        {
            if (Left(i) < collection.Length)
                return true;
            else
                return false;
        }

        private bool HasRight(int i)
        {
            if (Right(i) < collection.Length)
                return true;
            else
                return false;
        }

        private void MakeHeap(int i, int n)
        {
            int l = 2 * i + 1;
            int r = 2 * i + 2;
            int largest = i;
            if (l < n && collection[l] >= collection[largest])
                largest = l;

            if (r < n && collection[r] >= collection[largest])
                largest = r;

            if (largest != i)
            {
                Swap(i, largest);
                MakeHeap(largest, n);
            }
        }

        public void Sort()
        {
            BuildHeap();
            for (int i = collection.Length - 1; i >= 0; i--)
            {
                Swap(0, i);
                MakeHeap(0, i);
            }
        }

        private void InorderTraverse()
        {
            Stack<int> stack = new Stack<int>();
            int node = 0;
            stack.Push(node);
            while (true)
            {
                if (HasLeft(node))
                {
                    node = Left(node);
                    stack.Push(node);
                }
                else
                {
                    if (stack.Count > 0)
                    {
                        node = stack.Pop();
                        Console.Write(collection[node] + " ");
                        if (HasRight(node))
                        {
                            node = Right(node);
                            stack.Push(node);
                        }
                    }
                    else
                        break;
                }
            }
        }

        public void Insert(int item)
        {
            collection[currentSize] = item;
            HeapifyUp(currentSize);
            currentSize++;
        }
    }
}
