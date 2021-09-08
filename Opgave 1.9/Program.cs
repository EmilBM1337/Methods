using System;

namespace Opgave_1._9
{
    class Program
    {
        static float MiddelVærdien(float[]a, float n)
        {
            float prb = (1 / n);
            float sum = 0;

            for (int i = 0; i < n; i++)
                sum += a[i] * prb;

            return sum;
        }
        public static void Main()
        {
            float expect, n = 6f;
            float[] a = { 1f, 2f, 3f, 4f, 5f, 6f };

            expect = MiddelVærdien(a, n);

            Console.WriteLine("Middelværdien er: " + expect);
        }
    }
}
