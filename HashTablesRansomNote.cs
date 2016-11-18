using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank{
    class Solution
    {
        static void Main(String[] args)
        {
            string[] tokens_m = Console.ReadLine().Split(' ');
            int m = Convert.ToInt32(tokens_m[0]);
            int n = Convert.ToInt32(tokens_m[1]);
            string[] magazine = Console.ReadLine().Split(' ');
            string[] ransom = Console.ReadLine().Split(' ');

            Console.WriteLine(CheckWords(m, n, magazine, ransom));
        }

        static string CheckWords(int m, int n, string[] mag, string[] ransom)
        {
            int wordsNeeded = n;
            Dictionary<string, int> wordsAvailable = new Dictionary<string, int>();
            foreach(string x in mag)
            {
                if (wordsAvailable.ContainsKey(x))
                    wordsAvailable[x] += 1;
                else wordsAvailable.Add(x, 1);
            }

            foreach(string y in ransom)
            {
                if (wordsAvailable.ContainsKey(y))
                {
                    wordsAvailable[y] -= 1;
                }
                else wordsAvailable.Add(y, -1);
            }
            //if the word need to create the ransom note is not available, its value will be less than zero
            //after the check, if the words need to create are not enough, we will printout no
            foreach(int i in wordsAvailable.Values.ToList())
            {
                if (i < 0)
                    wordsNeeded--;
            }
            if (wordsNeeded == n)
                return "Yes";
            else return "No";
        }
    }
}
