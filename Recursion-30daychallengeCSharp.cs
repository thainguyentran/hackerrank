using System;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(factorial(n));
        }
        static int factorial(int i)
        {
            return (i == 1) ? 1 : i * factorial(i - 1);
        }
    }
}
