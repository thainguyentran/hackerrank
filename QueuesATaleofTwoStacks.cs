using System;
using System.Collections.Generic;

namespace HackerRank
{
    class Solution
    {
        static void Main(String[] args)
        {
            Functions f = new Functions();
            int q = Int32.Parse(Console.ReadLine());

            for(int i = 0; i < q; i++)
            {
                string[] queries = Console.ReadLine().Split(' ');

                switch(Int32.Parse(queries[0]))
                {
                    case 1: f.EnQueue(Int32.Parse(queries[1]));
                        break;
                    case 2: f.DeQueue();
                        break;
                    case 3: Console.WriteLine(f.Peek());
                        break;
                }
            }
        }
    }
    class Functions
    {
        private Stack<int> newestOnTop = new Stack<int>();
        private Stack<int> oldestOnTop = new Stack<int>();

        public void EnQueue(int x)
        {
            newestOnTop.Push(x);
        }

        public void DeQueue()
        {
            if (oldestOnTop.Count == 0)
            {
                swapStack();        
            }
            oldestOnTop.Pop();
        }

        public int Peek()
        {
            if (oldestOnTop.Count == 0)
            {
                swapStack();
            }
            return oldestOnTop.Peek();
        }

        public void swapStack()
        {
            while (newestOnTop.Count > 0)
                oldestOnTop.Push(newestOnTop.Pop());
        }
    }
}
