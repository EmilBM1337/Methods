using System;

namespace Opgave_1._4
{
    class Program
    {
        private static bool isPositive(int x)
        {
            if (x < 0)
                return false;
            else
                return true;
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            for (int i = 0; i < 100; i++)
            {
                int a = rnd.Next(int.MinValue, int.MaxValue);
                Console.WriteLine(a + " " + isPositive(a));
            }
        }
    }
}
