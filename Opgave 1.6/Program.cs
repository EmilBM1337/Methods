using System;

namespace Opgave_1._6
{
    class Program
    {
        static void IsEven(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("Tallet er LIGE");
            }
            else
            {
                Console.WriteLine("Tallet er ULIGE");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast et heltal: ");
            int x = int.Parse(Console.ReadLine());
            IsEven(x);
        }
    }
}
