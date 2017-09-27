using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 8, 7, 1, 3, 5, 6, 4 };
            QuickSortImpl sorter = new QuickSortImpl(arr);
            sorter.Sort();
            sorter.SortDescending();
        }
    }
}
