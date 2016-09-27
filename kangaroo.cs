using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string[] tokens_x1 = Console.ReadLine().Split(' ');
        int x1 = Convert.ToInt32(tokens_x1[0]);
        int v1 = Convert.ToInt32(tokens_x1[1]);
        int x2 = Convert.ToInt32(tokens_x1[2]);
        int v2 = Convert.ToInt32(tokens_x1[3]);
        int count = 0;
        int pre1 = 0, pre2 = 0;
        do
        {
            if (x1 == x2)
            {
                Console.WriteLine("YES");
                break;
            }
            else
            {
                pre1 = x1;
                pre2 = x2;
                x1 += v1;
                x2 += v2;
                if (x1 == x2)
                {
                    Console.WriteLine("YES");
                    break;
                }
                else
                {
                    if (Math.Abs(x1 - x2) >= Math.Abs(pre1 - pre2))
                    {
                        Console.WriteLine("NO");
                        break;
                    }
                }
                count++;
            }
        } while (true);
    }
}
