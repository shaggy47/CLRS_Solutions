using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        static int[] SelectSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                        min = j;
                }

                // swap with min
                int temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;
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

        static void Main(string[] args)
        {
            int[] arr = { 6, 5, 4, 3, 2, 1, 0 };
            arr = SelectSort(arr);
            Print(arr);
            Console.Read();
        }
    }
}
