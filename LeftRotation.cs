using System;

class Solution {
    static void Main(String[] args) {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int k = Convert.ToInt32(tokens_n[1]);
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp,Int32.Parse);
        k = k % n;
        int[] rotatedArray = new int[n];
        for (int i = 0; i < n; i++) {
        //for right rotation: (i + n - k) % n
            rotatedArray[i] = a[(i + n + k) % n];
        }
        foreach (int i in rotatedArray)
            Console.Write(i + " ");
    }
}
