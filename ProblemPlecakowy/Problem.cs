using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemPlecakowy
{
    internal class Problem
    {
        int n;
        int seed;
        List<Item> items;

        public Problem(int n, int seed)
        {
            this.n = n;
            this.seed = seed;
            this.items = new List<Item>();
            Random random = new Random(seed);


            for(int i = 0; i<n; i++)
            {
                int v = random.Next(1, 10);
                int w = random.Next(1, 10);

                items.Add(new Item(v, w, i));
            }
        }

        public override string ToString()
        {
            return $"items:\n"+ string.Join("\n", items);
        }

        public Result Solve(int capacity)
        {
            var sorted = items.OrderByDescending(i => (double)(i.value / i.weight)).ToList();
            List<int> result = new List<int>();
            int totalWeight = 0;
            int totalValue = 0;
            int leftSpace = capacity;
            foreach (Item i in sorted)
            {
                if (leftSpace >= i.weight)
                {
                    totalValue += i.value;
                    totalWeight+=i.weight;
                    result.Add(i.id);
                    leftSpace-=i.weight;
                }
            }


            return new Result(result, totalWeight, totalValue);
        }

    }
}
