int n = int.Parse(Console.ReadLine());
            List<int> f = new List<int>();
            f.Add(0);
            string[] temp = Console.ReadLine().Split(' ');
            foreach (string x in temp)
                f.Add(int.Parse(x));
            int[] inverseF = new int[n+1];
            for (int i = 1; i <= n; i++)
                inverseF[f[i]] = i;
            for (int i = 1; i<=n;i++)
                Console.WriteLine(inverseF[i]);
