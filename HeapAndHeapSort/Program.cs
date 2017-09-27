using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapAndHeapSort
{
    class Program
    {
        static void Main(string[] args)
        {
            MinHeap minHeap = new MinHeap();
            minHeap.Add(7);
            minHeap.Add(6);
            minHeap.Add(5);
            minHeap.Add(4);
            minHeap.Add(3);
            minHeap.Add(2);
            minHeap.Add(1);
            minHeap.Add(0);

            minHeap.PrintMin();
            int[] arr = { 7, 6, 5, 4, 3, 2, 1, 0 };
            Heap heap = new Heap(arr, HeapType.Min, 10);
            Console.Read();
        }
    }
}
