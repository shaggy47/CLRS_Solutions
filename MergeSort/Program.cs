using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            MergeSortImpl sorter = new MergeSortImpl(arr);
            sorter.SortIterative();
        }
    }
}
