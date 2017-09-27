using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching
{
    class Program
    {
        static int LinearSearch(int[] arr, int v)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == v)
                    return i;
            }

            return -1;
        }

        static int BinarySearch(int[] arr, int v, int i, int j)
        {
            int mid = (j + i) / 2;
            if (v < arr[mid])
                return BinarySearch(arr, v, i, mid);
            else if (v > arr[mid])
                return BinarySearch(arr, v, mid, j);
            else if (arr[mid] == v)
                return mid;
            else
                return -1;
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int k = LinearSearch(arr, 5);
            Console.WriteLine(k);
            for (int i = 0; i < arr.Length; i++)
            {
                k = BinarySearch(arr, arr[i], 0, arr.Length);
                Console.WriteLine(k);
            }
            
            Console.Read();
        }
    }
}
