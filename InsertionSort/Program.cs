using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        static int[] InsSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;

                // move elements that are greater than key to their right 
                // to find the proper place for key
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                // insert key to its proper place after the above loop.
                arr[j + 1] = key;
            }

            return arr;
        }

        static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
        }

        static int BinarySearch(int[] arr, int item, int low, int high)
        {
            if (high <= low)
                return (item > arr[low] ? low + 1 : low);

            int mid = (low + high) / 2;

            if (item == arr[mid])
                return mid + 1;

            if (item > arr[mid])
                return BinarySearch(arr, item, mid+1, high);

            return BinarySearch(arr, item, low, mid-1);
            
        }

        static int[] BinaryInsertion(int[] arr)
        {
            // todo excercise. come up with the algorithm for binary insertion.
            int item = 0;
            int j = 0;
            int loc = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                j = i - 1;
                item = arr[i];
                loc = BinarySearch(arr, item, 0, j);
                while (j >= loc)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j + 1] = item;
            }
            return arr;
        }

        static void Main(string[] args)
        {
            //unit test
            int[] arr = { 6, 5, 4, 3, 2, 1, 0 };
            BinaryInsertion(arr);
            //arr = InsSort(arr);
            Print(arr);
            Console.Read();
        }
    }
}
