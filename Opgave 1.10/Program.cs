using System;

namespace Opgave_1._10
{
    class Program
    {
        public static double Median(int[] a, int n)
        {
            Array.Sort(a);

            if (n % 2 != 0)
                return (double)a[n / 2];

            return (double)(a[(n - 1) / 2] + a[n / 2]) / 2.0;
        }
        public static void Main()
        {
            int[] a = { 1, 3, 4, 2, 7, 5, 8, 6 };
            int n = a.Length;

            Console.WriteLine("Medianen = " + Median(a, n) + "/n");
        }
    }
}
