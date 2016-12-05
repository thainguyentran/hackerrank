using System;
using System.Collections.Generic;

namespace HackerRank
{
    class Solution
    {

        static void Main(String[] args)
        {
            Functions f = new Functions();
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                string expression = Console.ReadLine();
                Console.WriteLine(f.CheckBrackets(expression));
            }
        }
    }
    class Functions
    {
        const string UNMATCHED = "NO";
        const string ALLMATCHED = "YES";
        private Stack<char> brackets;

        public string CheckBrackets(string line)
        {
            brackets = new Stack<char>();
            if (line.IndexOfAny("{}[]()".ToCharArray()) != -1)
            {
                foreach (char i in line)
                {
                    if (i == '{' || i == '(' || i == '[') brackets.Push(i);

                    if (i == '}' || i == ')' || i == ']')
                    {
                        if (brackets.Count == 0)
                            return UNMATCHED;
                        else
                        {
                            char leftBrackets = brackets.Pop();

                            if ((i == '}' && leftBrackets != '{')
                            || (i == ')' && leftBrackets != '(')
                            || (i == ']' && leftBrackets != '['))
                                return UNMATCHED;
                        }
                    }
                }
                if (brackets.Count == 0)
                    return ALLMATCHED;
                else return UNMATCHED;
            }
            return UNMATCHED;
        }
    }
}
