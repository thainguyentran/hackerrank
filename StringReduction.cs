using System;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(StringReduction(Console.ReadLine()));
            }
            Console.Read();
        }
        static int StringReduction(string a)
        {
            int countA = 0, countB = 0, countC = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == 'a' || a[i] == 'A')
                    countA++;
                else if (a[i] == 'b' || a[i] == 'B')
                    countB++;
                else if (a[i] == 'c' || a[i] == 'C')
                    countC++;
            }
            if ((countA == 0 && countB == 0) || (countA == 0 && countC == 0) || (countB == 0 && countC == 0))
                return a.Length;
            else if ((countA % 2 == 0 && countB % 2 == 0 && countC % 2 == 0) || (countA % 2 == 1 && countB % 2 == 1 && countC % 2 == 1))
                return 2;
            else return 1;


        }
    }
}
