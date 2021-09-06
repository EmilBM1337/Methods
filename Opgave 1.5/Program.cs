using System;

namespace Opgave_1._5
{
    class Program
    {
        private static void Calculate(int a)
        {
            Console.WriteLine("Kvadratet: " + a * a);
            if (a >= 0)
            Console.WriteLine("Kvadratroden: " + Math.Sqrt(a));

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast et tal: ");
            int x = int.Parse(Console.ReadLine());
            Calculate(x);
        }
    }
}
