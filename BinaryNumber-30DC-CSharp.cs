using System;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int remainder = 0, count = 0, max = 0;
            while (n > 0)
            {
                //not using built in function to convert from decimal to binary.
                //using the old fashion way
                remainder = n % 2;
                n = n / 2;
                if (remainder == 1)
                {
                    count++;
                    //to count the consecutive, we need the max value
                    if (max < count)
                        max = count;
                }
                else count = 0;
            }
            Console.WriteLine(max);
        }
    }
}
