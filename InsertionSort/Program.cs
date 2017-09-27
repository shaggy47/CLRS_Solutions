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

        static int[] BinaryInsertion(int[] arr)
        {
            // todo excercise. come up with the algorithm for binary insertion.
            return arr;
        }

        static void Main(string[] args)
        {
            //unit test
            int[] arr = { 6, 5, 4, 3, 2, 1, 0 };
            arr = InsSort(arr);
            Print(arr);
            Console.Read();
        }
    }
}
