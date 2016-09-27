using System;

class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int n = Convert.ToInt32(Console.ReadLine());
            string[] temp = Console.ReadLine().Split(' ');
            int[] f = new int[n + 1];
            int[] fofF = new int[n + 1];
            for (int i = 1; i <= n; i++)
                f[i] = Convert.ToInt32(temp[i-1]);
            for (int i = 1; i <= n; i++)
                Console.WriteLine(f[f[i]]);
    }
}
