using System;

namespace Opgave_1._3
{
    class Program
    {
        private static void Calculate()
        {
            Console.WriteLine("Skriv det første hele tal.");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Skriv det andet hele tal.");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Plus:     {0}", x + y);
            Console.WriteLine("Minus:    {0}", x - y);
            Console.WriteLine("Gange:    {0}", x * y);
            Console.WriteLine("Division: {0}", x / y);
        }
        static void Main(string[] args)
        {
            Calculate();
        }
    }
}
