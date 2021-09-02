using System;

namespace Opgave_1._2
{
    class Program
    {
        private static void Print()
        {
            int tal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nTallet er: " + tal);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv et helt tal.");
            Print();
        }
    }
}
