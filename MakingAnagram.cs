using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
        string a = Console.ReadLine();
        string b = Console.ReadLine();
        Console.WriteLine(CharToRemove(a, b));
    }
    
    static int CharToRemove(string a, string b)
    {
        int total = 0;
        
        //a Dictionary to map out the occurences of each character in the two strings
        Dictionary<char, int> charCount = new Dictionary<char, int>();
        
        //we will use the first string as the base
        //if the character is unique, it will be counted as 1 (occured once), 
        //if the character repeative, its occurence will be added
        foreach(char x in a.ToCharArray())
        {
            if (charCount.ContainsKey(x))
                charCount[x] += 1;
            else charCount.Add(x, 1);
        }
        
        //for the second string, if the character is already in the dictionary, 
        //means that these character will make an anagram, so they can be removed. Hence, we will deduct the occurence by one
        //if the character have never appeared in the first string and is unique, 
        //means it will be removed, so its occurence counted as -1
        foreach (char y in b.ToCharArray())
        {
            if (charCount.ContainsKey(y))
                charCount[y] -= 1;
            else charCount.Add(y, -1);
        }
        //get all the values of occurences of each character of both strings
        List<int> valuesOfCharCount = charCount.Values.ToList();
        
        //count the number of character we have to remove to get an anagram
        foreach (int i in valuesOfCharCount)
        {
            total += Math.Abs(i);
        }
        return total;
    }
}
