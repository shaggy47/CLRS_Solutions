using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSubArray
{
    class Program
    {
        static int Sum(int[] arr, int index)
        {
            int sum = arr[index];

            if (index + 1 < arr.Length)
                return sum + Sum(arr, index + 1);

            return sum;
        }

        static int Max(int a, int b, int c)
        {
            if (a > b && a > c)
                return a;
            else if (b > a && b > c)
                return b;
            else
                return c;
        }

        static int MaxCrossingSubArray(int[] arr, int l, int m, int h)
        {
            int sum = 0;
            int lSum = int.MinValue;
            int rSum = int.MinValue;
            for (int i = m; i >= l; i--)
            {
                sum += arr[i];
                if (sum > lSum)
                    lSum = sum;
            }
            sum = 0;
            for (int i = m + 1; i <= h; i++)
            {
                sum += arr[i];
                if (sum > rSum)
                    rSum = sum;
            }

            return lSum + rSum;
        }

        static int MaxSubArray(int[] arr, int l, int h)
        {
            if (l == h)
                return arr[l];
            int m = (h + l) / 2;
            int sum1 = MaxSubArray(arr, l, m);
            int sum2 = MaxSubArray(arr, m + 1, h);
            int sum3 = MaxCrossingSubArray(arr, l, m, h);
            Console.WriteLine("l={0} m={1} h={2}", l, m, h);
            return Max(sum1, sum2, sum3);
        }

        static int FindMaxSumIterative(int[] arr)
        {
            int sum = 0;
            int max = int.MinValue;
            int maxIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                if (max < sum)
                {
                    max = sum;
                    maxIndex = i;
                }

                if (sum < 0)
                    sum = 0;
            }

            return max;
        }

        static void Main(string[] args)
        {
            int[] arr = { -5, -4, -1, -3, 16, 4, 7, 2, 1, -8, -1, 0, 1, -16, 5, 5, 5, 5, 5, 5, 5 };
            int[] arr2 = { -1, -2, 3, 4, 5, -5, -2, -1, 0 };
            int x = 0;// MaxSubArray(arr, 0, arr.Length - 1);
            x = FindMaxSumIterative(arr);
        }
    }
}
