using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices
{
    class Program
    {
        static int DaysInMonth(int x)
        {
            return 28 + (x + (int)Math.Floor((decimal)x / 8)) % 2 + 2 % x + 2 * (int)Math.Floor((decimal)1 / x);
        }

        static string DayOfTheProgrammer(int y)
        {
            string date = string.Empty;
            int[] nonLeapDays = { 0, 31, 28, 31, 30, 31, 30, 31, 31 };
            int[] leapDays = { 0, 31, 29, 31, 30, 31, 30, 31, 31 };
            int dayOfProgrammer = 256;

            if (y >= 1918)
            {
                // leap year
                if (y % 4 == 0 && y % 100 != 0)
                {
                    int d = dayOfProgrammer - leapDays.Sum();
                    DateTime actualDate = new DateTime(y, 9, d);
                    date = actualDate.ToString("dd.MM.yyyy");
                }
                else
                {
                    int d = dayOfProgrammer - nonLeapDays.Sum();
                    DateTime actualDate = new DateTime(y, 9, d);
                    date = actualDate.ToString("dd.MM.yyyy");
                }
            }
            else
            {
                // leap year
                if (y % 4 == 0)
                {
                    int d = dayOfProgrammer - leapDays.Sum();
                    DateTime actualDate = new DateTime(y, 9, d);
                    date = actualDate.ToString("dd.MM.yyyy");
                }
                else
                {
                    int d = dayOfProgrammer - nonLeapDays.Sum();
                    DateTime actualDate = new DateTime(y, 9, d);
                    date = actualDate.ToString("dd.MM.yyyy");
                }
            }

            return date;

        }
        static int MultiplyRecursive(int[,] A, int[,] B, int[,] C, int i, int j, int n, int k, int p)
        {

            return 0;
        }

        static void Traverse(int[,] M, int i, int j)
        {
            Console.Write("{0} ", M[i, j]);
            if (i == M.GetUpperBound(0) && j == M.GetUpperBound(1))
                return;

            if (j < M.GetUpperBound(1))
            {
                Traverse(M, i, j + 1);
            }
            else
            {
                j = 0;
                Console.WriteLine();
                Traverse(M, i + 1, j++);
            }
        }

        static void Main(string[] args)
        {
            // int d = DaysInMonth(1);
            string x = DayOfTheProgrammer(2000);

            Console.Read();
        }
    }
}
