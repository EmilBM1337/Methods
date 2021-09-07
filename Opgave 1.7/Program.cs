using System;

namespace Opgave_1._7
{
    class Program
    {
        static bool HasEqualLenght(int[] numbers, string[] letters)
        {
            if (numbers.Length == letters.Length)
                return true;
            else
                return false;
        }
        static void Print(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Index " + i + " ");
                Console.WriteLine(numbers[i]);
            }
        }
        static void Main(string[] args)
        {
            int x = 2;
            int y = 14;
            int[] i = { x, y , 8, 16, 9};
            string[] brothers = { "Groucho Marx", "Chico Marx", "Harpo Marx", "Zeppo Marx", "Gummo Marx" };
            //Print(i);
            Console.WriteLine(HasEqualLenght(i, brothers)); 
        }
    }
}
